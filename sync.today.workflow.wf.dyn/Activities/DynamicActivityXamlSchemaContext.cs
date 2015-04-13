using System;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xaml;
using System.Xaml.Schema;
using System.Xml.Linq;

namespace sync.today.workflow.wf.dyn.Activities
{
    /// <summary>
    /// XamlSchemaContext implementation that allows x:Class Activities to be referenced and used
    /// from other workflows as DynamicActivities, without requiring compilation.
    /// </summary>
    /// <remarks>
    /// This abstract base class does not provide a mechanism for discovering types; that needs to
    /// be supplied in a concrete derived class.
    /// </remarks>
    public abstract class DynamicActivitySchemaContextBase : XamlSchemaContext
    {
        private ConcurrentDictionary<XName, DynamicActivityXamlType> _types =
            new ConcurrentDictionary<XName, DynamicActivityXamlType>();

        public DynamicActivitySchemaContextBase()
            : base()
        {
        }

        public override IEnumerable<string> GetAllXamlNamespaces()
        {
            var customNamespaces = from pair in _types
                                   // GetAllXamlNamespaces does not customarily include clr-namespaces
                                   where pair.Key.NamespaceName != pair.Value.ClrNamespace
                                   select pair.Key.NamespaceName;
            return base.GetAllXamlNamespaces().Concat(customNamespaces).Distinct();
        }

        /// <summary>
        /// Lists all types in the given namespace, including any dynamic activity types that have
        /// already been loaded.
        /// </summary>
        /// <remarks>
        /// Only includes dynamic activity types that have already been loaded; even if the namespace
        /// is registered, does not search the corresponding path for additional XAML files.
        /// </remarks>
        public override ICollection<XamlType> GetAllXamlTypes(string xamlNamespace)
        {
            var result = from pair in _types
                         where pair.Key.NamespaceName == xamlNamespace
                         select pair.Value;
            List<XamlType> resultList = result.Cast<XamlType>().ToList();
            if (resultList.Count > 0)
            {
                // If we have any types in this namespace, concatenate our list with whatever the base context returns
                resultList.AddRange(base.GetAllXamlTypes(xamlNamespace));
                return resultList.AsReadOnly();
            }
            return base.GetAllXamlTypes(xamlNamespace);
        }

        public override bool TryGetCompatibleXamlNamespace(string xamlNamespace, out string compatibleNamespace)
        {
            bool result = base.TryGetCompatibleXamlNamespace(xamlNamespace, out compatibleNamespace);
            if (!result && IsNamespaceKnown(xamlNamespace))
            {
                // The base schema context doesn't recognize this namespace as known, but we do
                compatibleNamespace = xamlNamespace;
                return true;
            }
            return result;
        }

        protected override XamlType GetXamlType(string xamlNamespace, string name, params XamlType[] typeArguments)
        {
            if (typeArguments == null || typeArguments.Length == 0)
            {
                DynamicActivityXamlType result;
                XName key = XName.Get(name, xamlNamespace);
                if (_types.TryGetValue(key, out result))
                {
                    return result;
                }
                result = LookupXamlType(xamlNamespace, name);
                if (result != null)
                {
                    result = TryAddXamlType(key, result);
                    return result;
                }
            }
            return base.GetXamlType(xamlNamespace, name, typeArguments);
        }

        private DynamicActivityXamlType TryAddXamlType(XName qualifiedName, DynamicActivityXamlType type)
        {
            XName clrName = XName.Get(type.Name, type.ClrNamespace);
            if (!_types.TryAdd(clrName, type))
            {
                type = _types[clrName];
            }
            if (qualifiedName.NamespaceName != type.ClrNamespace)
            {
                bool typeIsAlreadyRegistered = !_types.TryAdd(qualifiedName, type);
                if (typeIsAlreadyRegistered && _types[qualifiedName] != type)
                {
                    string oldClassName = _types[qualifiedName].Descriptor.GetClassName();
                    string newClassName = type.Descriptor.GetClassName();
                    Debug.Assert(oldClassName != newClassName, "Only one type should ever be registered for a given class name");
                    throw new XamlSchemaException(string.Format("Cannot map {0} to {1} because it is already mapped to {2}.",
                        qualifiedName, newClassName, oldClassName));
                }
            }
            return type;
        }

        protected abstract DynamicActivityXamlType LookupXamlType(string xamlNamespace, string name);

        protected virtual bool IsNamespaceKnown(string xamlNamespace)
        {
            return _types.Any(pair => pair.Key.NamespaceName == xamlNamespace);
        }
    }

    /// <summary>
    /// XamlSchemaContext implementation that allows x:Class Activities to be referenced and used
    /// from other workflows as DynamicActivities, without requiring compilation.
    /// </summary>
    /// <remarks>
    /// Make types discoverable by calling RegisterNamespace(Uri,string).
    /// </remarks>
    public class DynamicActivitySchemaContext : DynamicActivitySchemaContextBase
    {
        private ConcurrentDictionary<string, DynamicActivityXamlType> _typesByPath =
            new ConcurrentDictionary<string, DynamicActivityXamlType>(StringComparer.OrdinalIgnoreCase);

        private ConcurrentBag<UriToPathMapping> _namespaces =
            new ConcurrentBag<UriToPathMapping>();

        public DynamicActivitySchemaContext()
            : base()
        {
        }

        public override IEnumerable<string> GetAllXamlNamespaces()
        {
            var customNamespaces = from mapping in _namespaces
                                   select mapping.Uri.ToString();
            return base.GetAllXamlNamespaces().Concat(customNamespaces).Distinct();
        }

        /// <summary>
        /// Maps a namespace to a directory on disk where Activity XAML files can be found.
        /// </summary>
        /// <remarks>
        /// Types will be resolved in this namespace by looking for 'Name.xaml' where Name is the
        /// name of the  type being resolved.<br/><br/>
        /// URIs based at this namespace will be resolved as subdirectories of the path.<br/><br/>
        /// E.g. If http://myworkflows is mapped to c:\myworkflows, then {http://myworkflows/sub}MyActivity
        /// will map to c:\myworkflows\sub\MyActivity.xaml.<br/><br/>
        /// In case of overlapping or duplicate URIs, results are undefined.
        /// </remarks>
        public void RegisterNamespace(Uri namespaceUri, string path)
        {
            namespaceUri.CheckNotNull("namespaceUri");
            path.CheckNotNull("path");
            if (!namespaceUri.IsAbsoluteUri)
            {
                throw new ArgumentException("URI must be absolute.", "namespaceUri");
            }
            string directory = EnsureDirectorySeparatorChar(Path.GetFullPath(path));
            _namespaces.Add(new UriToPathMapping(namespaceUri, directory));
        }

        #region XamlType handling

        protected override DynamicActivityXamlType LookupXamlType(string xamlNamespace, string name)
        {
            string path = GetPathTo(xamlNamespace);
            if (path != null)
            {
                string fullPath = Path.Combine(path, name + ".xaml");
                DynamicActivityXamlType result = GetXamlType(fullPath);
                if (result.Name != name)
                {
                    throw new XamlSchemaException(string.Format(
                        "Activity at path {0} has name {1}; expected {2}.", fullPath, result.Name, name));
                }
                return result;
            }
            return null;
        }

        private DynamicActivityXamlType GetXamlType(string path)
        {
            string fullPath = Path.GetFullPath(path);
            DynamicActivityXamlType result;
            if (_typesByPath.TryGetValue(fullPath, out result))
            {
                return result;
            }

            result = CreateXamlType(path);
            if (!_typesByPath.TryAdd(fullPath, result))
            {
                result = _typesByPath[fullPath];
            }
            return result;
        }

        private DynamicActivityXamlType CreateXamlType(string path)
        {
            XamlNodeList xamlNodes = new XamlNodeList(this);
            using (XamlXmlReader xamlReader = new XamlXmlReader(path, this))
            {
                XamlServices.Transform(xamlReader, xamlNodes.Writer);
            }

            // Namespaces are only evaluated at construction, so if an additional namespace is
            // registered later, we don't update the XamlType.
            IEnumerable<string> namespaces = GetNamespacesFor(path).OrderBy(ns => ns, StringComparer.Ordinal);
            DynamicActivityXamlType result = new DynamicActivityXamlType(xamlNodes, namespaces);
            return result;
        }

        #endregion

        #region Namespace mapping

        protected override bool IsNamespaceKnown(string xamlNamespace)
        {
            return base.IsNamespaceKnown(xamlNamespace) || GetPathTo(xamlNamespace) != null;
        }

        private IEnumerable<string> GetNamespacesFor(string fileName)
        {
            string path = EnsureDirectorySeparatorChar(Path.GetDirectoryName(fileName));
            var result = from mapping in _namespaces
                         select mapping.GetUriFor(path);
            return from uri in result
                   where uri != null
                   select uri.ToString();
        }

        private string GetPathTo(string xamlNamespace)
        {
            Uri namespaceAsUri;
            if (xamlNamespace.EndsWith("/", StringComparison.OrdinalIgnoreCase) &&
                Uri.TryCreate(xamlNamespace, UriKind.Absolute, out namespaceAsUri))
            {
                var result = from mapping in _namespaces
                         select mapping.GetPathFor(namespaceAsUri);
                return result.Where(s => s != null).FirstOrDefault();
            }
            return null;
        }

        private static string EnsureDirectorySeparatorChar(string path)
        {
            char lastChar = path.Length > 0 ? path[path.Length-1] : char.MinValue;
            if (lastChar != Path.DirectorySeparatorChar && 
                lastChar != Path.AltDirectorySeparatorChar)
            {
                return path + Path.DirectorySeparatorChar;
            }
            return path;
        }

        private class UriToPathMapping
        {
            public Uri Uri { get; private set; }

            public string MappedPath { get; private set; }

            public UriToPathMapping(Uri uri, string path)
            {
                Debug.Assert(EnsureDirectorySeparatorChar(path) == path);
                Uri = uri;
                MappedPath = path;
            }

            public string GetPathFor(Uri uri)
            {
                if (this.Uri == uri)
                {
                    return MappedPath;
                }
                if (this.Uri.IsBaseOf(uri))
                {
                    Uri subUri = this.Uri.MakeRelativeUri(uri);
                    string subPath = subUri.ToString().Replace('/', Path.DirectorySeparatorChar);
                    return Path.Combine(MappedPath, subPath);
                }
                return null;
            }

            public Uri GetUriFor(string path)
            {
                Debug.Assert(EnsureDirectorySeparatorChar(path) == path);
                if (path.StartsWith(MappedPath, StringComparison.OrdinalIgnoreCase))
                {
                    string subPath = path.Substring(MappedPath.Length);
                    if (subPath == string.Empty)
                    {
                        return this.Uri;
                    }
                    string subUri = subPath.Replace(Path.DirectorySeparatorChar, '/').Replace(Path.AltDirectorySeparatorChar, '/');
                    return new Uri(this.Uri, subUri);
                }
                return null;
            }
        }

        #endregion
    }
}

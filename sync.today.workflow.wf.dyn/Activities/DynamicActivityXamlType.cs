using System;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xaml;
using System.Xaml.Schema;
using sync.today.workflow.wf.dyn.TypeDescription;

namespace sync.today.workflow.wf.dyn.Activities
{
    public class DynamicActivityXamlType : TypeDescriptorXamlType
    {
        private IList<string> _namespaces;

        public DynamicActivityXamlType(XamlNodeList xamlNodes)
            : this(xamlNodes, null)
        {
        }

        public DynamicActivityXamlType(XamlNodeList xamlNodes, IEnumerable<string> xamlNamespaces)
            : base(LoadAndValidateActivity(xamlNodes.CheckNotNull("xamlNodes")), xamlNodes.Writer.SchemaContext)
        {
            XamlNodes = xamlNodes;
            if (xamlNamespaces != null)
            {
                List<string> namespaces = xamlNamespaces.ToList();
                if (namespaces.Count > 0)
                {
                    namespaces.Add(ClrNamespace);
                    _namespaces = namespaces.AsReadOnly();
                }
            }
        }

        public XamlReader GetXaml()
        {
            return XamlNodes.GetReader();
        }

        public override IList<string> GetXamlNamespaces()
        {
            if (_namespaces != null)
            {
                return _namespaces;
            }
            return base.GetXamlNamespaces();
        }

        internal object LoadActivity()
        {
            return LoadActivity(XamlNodes);
        }

        internal string ClrNamespace { get { return base.GetXamlNamespaces()[0]; } }

        internal XamlNodeList XamlNodes { get; private set; }

        protected override XamlType LookupBaseType()
        {
            return SchemaContext.GetXamlType(Descriptor.GetType());
        }

        protected override XamlTypeInvoker LookupInvoker()
        {
            return new DynamicActivityInvoker(this);
        }

        protected override XamlMember LookupMember(string name, bool skipReadOnlyCheck)
        {
            XamlMember result = base.LookupMember(name, skipReadOnlyCheck);
            var descriptorMember = result as PropertyDescriptorXamlMember;
            if (descriptorMember != null)
            {
                Type componentType = descriptorMember.Descriptor.ComponentType;
                if (componentType.IsDynamicActivity())
                {
                    result = new DynamicActivityXamlMember(descriptorMember.Descriptor, descriptorMember.DeclaringType);
                }
            }
            return result;
        }

        private static object LoadActivity(XamlNodeList xamlNodes)
        {
            XamlReader reader = ActivityXamlServices.CreateReader(xamlNodes.GetReader(), xamlNodes.Writer.SchemaContext);
            return XamlServices.Load(reader);
        }

        private static ICustomTypeDescriptor LoadAndValidateActivity(XamlNodeList xamlNodes)
        {
            object result = LoadActivity(xamlNodes);
            if (result == null || !result.GetType().IsDynamicActivity())
            {
                throw new ArgumentException("The root type of the XAML must be Activity, and the root element must contain an x:Class directive", "xamlNodes");
            }
            return (ICustomTypeDescriptor)result;
        }
    }

    public class DynamicActivityInvoker : XamlTypeInvoker
    {
        DynamicActivityXamlType _xamlType;

        public DynamicActivityInvoker(DynamicActivityXamlType xamlType)
            : base(xamlType)
        {
            _xamlType = xamlType;
        }

        public override object CreateInstance(object[] arguments)
        {
            if (arguments != null && arguments.Length > 0)
            {
                throw new NotSupportedException("Constructor arguments are not supported on dynamic activities");
            }
            return _xamlType.LoadActivity();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xaml;
using System.Xaml.Schema;
using System.Diagnostics;

namespace sync.today.workflow.wf.dyn.TypeDescription
{
    /// <summary>
    /// Class that obtains XAML type information from an ICustomTypeDescriptor
    /// </summary>
    /// <remarks>
    /// System.Xaml assumes that type information is immutable. The TypeDescriptor should be fully populated
    /// before this XamlType is used.
    /// </remarks>
    public class TypeDescriptorXamlType : XamlType
    {
        private IList<string> _namespaces;

        public TypeDescriptorXamlType(ICustomTypeDescriptor typeDescriptor, XamlSchemaContext schemaContext)
            : this(typeDescriptor, schemaContext, (IList<XamlType>)null)
        {
        }

        public TypeDescriptorXamlType(ICustomTypeDescriptor typeDescriptor, XamlSchemaContext schemaContext, IList<XamlType> typeArguments)
            : base(ExtractTypeName(typeDescriptor.CheckNotNull("typeDescriptor")), typeArguments, schemaContext)
        {
            Descriptor = typeDescriptor;
        }

        public TypeDescriptorXamlType(Type type, XamlSchemaContext schemaContext)
            : this(type, schemaContext, null)
        {
        }

        public TypeDescriptorXamlType(Type type, XamlSchemaContext schemaContext, ICustomTypeDescriptor typeDescriptor)
            : base(type, schemaContext)
        {
            Descriptor = typeDescriptor ?? TypeDescriptor.GetProvider(type).GetTypeDescriptor(type);
            if (Descriptor == null)
            {
                throw new InvalidOperationException(string.Format("TypeDescriptionProvider.GetTypeDescriptor returned null for {0}", type));
            }
        }

        public ICustomTypeDescriptor Descriptor { get; private set; }

        public override IList<string> GetXamlNamespaces()
        {
            if (UnderlyingType != null)
            {
                return base.GetXamlNamespaces();
            }
            if (_namespaces == null)
            {
                string result = "clr-namespace:" + ExtractNamespace(Descriptor);
                _namespaces = new ReadOnlyCollection<string>(new string[] { result });
            }
            return _namespaces;
        }

        protected override ICustomAttributeProvider LookupCustomAttributeProvider()
        {
            return new CollectionAttributeProvider(Descriptor.GetAttributes());
        }

        protected override XamlValueConverter<TypeConverter> LookupTypeConverter()
        {
            TypeConverter converter = Descriptor.GetConverter();
            if (converter == null || ConverterHelper.IsNonXaml(converter))
            {
                if (ConverterHelper.HasXamlSpecificBuiltInConverter(UnderlyingType))
                {
                    return base.LookupTypeConverter();
                }
                return null;
            }
            return new SpecifiedInstanceValueConverter(converter);
        }

        protected override XamlTypeInvoker LookupInvoker()
        {
            return new TypeDescriptorXamlTypeInvoker(this);
        }

        protected override IEnumerable<XamlMember> LookupAllMembers()
        {
            foreach (PropertyDescriptor prop in Descriptor.GetProperties())
            {
                XamlMember member = GetMember(prop.Name);
                if (member != null)
                {
                    yield return member;
                }
            }
            foreach (EventDescriptor evt in Descriptor.GetEvents())
            {
                XamlMember member = GetMember(evt.Name);
                if (member != null && member.IsEvent) // just in case a property shadows an event with the same name
                {
                    yield return member;
                }
            }
        }

        protected override XamlMember LookupMember(string name, bool skipReadOnlyCheck)
        {
            var memberDescriptor = (MemberDescriptor)Descriptor.GetProperties()[name] ?? Descriptor.GetEvents()[name];
            if (memberDescriptor == null)
            {
                return null;
            }

            XamlMember result = GetInheritedMember(memberDescriptor);
            if (result != null)
            {
                return result;
            }

            PropertyDescriptor prop = memberDescriptor as PropertyDescriptor;
            if (prop != null)
            {
                return CreateXamlProperty(prop, skipReadOnlyCheck);
            }
            else
            {
                return CreateXamlEvent((EventDescriptor)memberDescriptor);
            }
        }

        protected override bool LookupIsUnknown()
        {
            return false;
        }

        private XamlMember GetInheritedMember(MemberDescriptor member)
        {
            if (BaseType == null)
            {
                return null;
            }
            MemberDescriptorXamlMember baseMember = BaseType.GetMember(member.Name) as MemberDescriptorXamlMember;
            if (baseMember == null || baseMember.Descriptor != member)
            {
                return null;
            }
            return baseMember;
        }

        private bool AllowAsReadOnly(PropertyDescriptor property)
        {
            XamlType propertyType = SchemaContext.GetXamlType(property.PropertyType);
            return propertyType.IsCollection || propertyType.IsDictionary || propertyType.IsXData;
        }

        private XamlMember CreateXamlEvent(EventDescriptor evt)
        {
            return new EventDescriptorXamlMember(evt, this);
        }

        private XamlMember CreateXamlProperty(PropertyDescriptor property, bool skipReadOnlyCheck)
        {
            XamlType declaringType = this;
            if (property.IsReadOnly)
            {
                if (!skipReadOnlyCheck && !AllowAsReadOnly(property))
                {
                    return null;
                }

                // The property might actually be defined on a base type, but not returned by
                // GetInheritedMember because it is read-only.
                // If so, we should set its declaringType to the base type.
                if (skipReadOnlyCheck && property.ComponentType != UnderlyingType &&
                    TypeDescriptor.GetProperties(property.ComponentType)[property.Name] == property)
                {
                    declaringType = SchemaContext.GetXamlType(property.ComponentType);
                }
            }
            return new PropertyDescriptorXamlMember(property, declaringType);
        }

        private static string ExtractNamespace(ICustomTypeDescriptor typeDescriptor)
        {
            string name = typeDescriptor.GetClassName();
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            int lastDot = name.LastIndexOf(".");
            return (lastDot >= 0) ? name.Substring(0, lastDot) : string.Empty;
        }

        private static string ExtractTypeName(ICustomTypeDescriptor typeDescriptor)
        {
            string name = typeDescriptor.GetClassName();
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            int lastDot = name.LastIndexOf(".");
            return (lastDot >= 0) ? name.Substring(lastDot + 1) : name;
        }
    }

    /// <summary>
    /// Class that instantiates types from XAML via TypeDescriptor.
    /// </summary>
    /// <remarks>
    /// All operations other than instantiation are implemented in the base XamlTypeInvoker.
    /// </remarks>
    public class TypeDescriptorXamlTypeInvoker : XamlTypeInvoker
    {
        public Type Type { get; private set; }

        public TypeDescriptorXamlTypeInvoker(TypeDescriptorXamlType xamlType)
            : base(xamlType)
        {
            this.Type = xamlType.UnderlyingType;
        }

        public override object CreateInstance(object[] arguments)
        {
            if (this.Type != null)
            {
                return TypeDescriptor.CreateInstance(null, this.Type, null, arguments);
            }
            return base.CreateInstance(arguments);
        }
    }
}

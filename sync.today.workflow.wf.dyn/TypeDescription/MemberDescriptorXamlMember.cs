using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xaml;
using System.Xaml.Schema;

namespace sync.today.workflow.wf.dyn.TypeDescription
{
    /// <summary>
    /// Class that obtains XAML member information from a Member Descriptor
    /// </summary>
    public class MemberDescriptorXamlMember : XamlMember
    {
        public MemberDescriptorXamlMember(MemberDescriptor member, XamlType declaringType)
            : base(member.CheckNotNull("member").Name, declaringType, false)
        {
            Descriptor = member;
        }

        public MemberDescriptor Descriptor { get; private set; }

        protected override ICustomAttributeProvider LookupCustomAttributeProvider()
        {
            return new CollectionAttributeProvider(Descriptor.Attributes);
        }

        protected override bool LookupIsUnknown()
        {
            return false;
        }
    }

    /// <summary>
    /// Class that obtains XAML property information from a Property Descriptor
    /// </summary>
    public class PropertyDescriptorXamlMember : MemberDescriptorXamlMember
    {
        public PropertyDescriptorXamlMember(PropertyDescriptor property, XamlType declaringType)
            : base(property.CheckNotNull("property"), declaringType)
        {
        }

        public new PropertyDescriptor Descriptor { get { return (PropertyDescriptor)base.Descriptor; } }

        protected override XamlMemberInvoker LookupInvoker()
        {
            return new PropertyDescriptorXamlMemberInvoker(this);
        }

        protected override bool LookupIsReadOnly()
        {
            return Descriptor.IsReadOnly;
        }

        protected override XamlType LookupType()
        {
            return DeclaringType.SchemaContext.GetXamlType(Descriptor.PropertyType);
        }

        protected override XamlValueConverter<TypeConverter> LookupTypeConverter()
        {
            TypeConverter converter = Descriptor.Converter;
            var propertyTypeConverter = this.Type.TypeConverter;
            if (converter == null ||
                ConverterHelper.IsNonXaml(converter) ||
                (propertyTypeConverter != null && propertyTypeConverter.ConverterInstance == converter))
            {
                return propertyTypeConverter;
            }
            return new SpecifiedInstanceValueConverter(converter);
        }
    }

    /// <summary>
    /// Adapter from PropertyDescriptor to XamlMemberInvoker
    /// </summary>
    public class PropertyDescriptorXamlMemberInvoker : XamlMemberInvoker
    {
        public PropertyDescriptor Descriptor { get; private set; }

        public PropertyDescriptorXamlMemberInvoker(PropertyDescriptorXamlMember xamlMember)
            : base(xamlMember)
        {
            Descriptor = xamlMember.Descriptor;
        }

        public override object GetValue(object instance)
        {
            return Descriptor.GetValue(instance);
        }

        public override void SetValue(object instance, object value)
        {
            Descriptor.SetValue(instance, value);
        }

        public override ShouldSerializeResult ShouldSerializeValue(object instance)
        {
            if (Descriptor.IsReadOnly)
            {
                // The default PropertyDescriptor implementation requires SerializationVisibility.Content
                // on visible read-only properties. XAML eliminates this requirement, so we need to use
                // XAML's implementation of ShouldSerialize.
                return base.ShouldSerializeValue(instance);
            }
            return Descriptor.ShouldSerializeValue(instance) ? ShouldSerializeResult.True : ShouldSerializeResult.False;
        }
    }

    /// <summary>
    /// Class that obtains XAML event information from an Event Descriptor
    /// </summary>
    public class EventDescriptorXamlMember : MemberDescriptorXamlMember
    {
        public EventDescriptorXamlMember(EventDescriptor evt, XamlType declaringType)
            : base(evt.CheckNotNull("evt"), declaringType)
        {
        }

        public new EventDescriptor Descriptor { get { return (EventDescriptor)base.Descriptor; } }

        protected override XamlMemberInvoker LookupInvoker()
        {
            return new EventDescriptorXamlMemberInvoker(this);
        }

        protected override bool LookupIsEvent()
        {
            return true;
        }

        protected override bool LookupIsWriteOnly()
        {
            return true;
        }

        protected override XamlType LookupType()
        {
            return DeclaringType.SchemaContext.GetXamlType(Descriptor.EventType);
        }
    }

    /// <summary>
    /// Adapter from EventDescriptor to XamlMemberInvoker
    /// </summary>
    public class EventDescriptorXamlMemberInvoker : XamlMemberInvoker
    {
        public EventDescriptor Descriptor { get; private set; }

        public EventDescriptorXamlMemberInvoker(EventDescriptorXamlMember xamlMember)
            : base(xamlMember)
        {
            Descriptor = xamlMember.Descriptor;
        }

        public override object GetValue(object instance)
        {
            throw new NotSupportedException("Cannot get the value of an event");
        }

        public override void SetValue(object instance, object value)
        {
            Delegate del = value as Delegate;
            if (value != null && del == null)
            {
                throw new ArgumentException("Value must be a delegate", "value");
            }
            Descriptor.AddEventHandler(instance, del);
        }
    }
}

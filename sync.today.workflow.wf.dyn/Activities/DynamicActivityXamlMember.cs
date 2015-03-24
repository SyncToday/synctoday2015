using System;
using System.ComponentModel;
using System.Xaml;
using System.Xaml.Schema;
using sync.today.workflow.wf.dyn.TypeDescription;

namespace sync.today.workflow.wf.dyn.Activities
{
    public class DynamicActivityXamlMember : PropertyDescriptorXamlMember
    {
        public DynamicActivityXamlMember(PropertyDescriptor property, XamlType declaringType)
            : base(property, declaringType)
        {
        }

        protected override XamlMemberInvoker LookupInvoker()
        {
            return new DynamicActivityPropertyInvoker(this);
        }
    }

    public class DynamicActivityPropertyInvoker : PropertyDescriptorXamlMemberInvoker
    {
        DynamicActivityXamlMember _xamlMember;

        public DynamicActivityPropertyInvoker(DynamicActivityXamlMember xamlMember)
            : base(xamlMember)
        {
            _xamlMember = xamlMember;
        }

        public override object GetValue(object instance)
        {
            return GetDescriptor(instance).GetValue(instance);
        }

        public override void SetValue(object instance, object value)
        {
            GetDescriptor(instance).SetValue(instance, value);
        }

        public override ShouldSerializeResult ShouldSerializeValue(object instance)
        {
            // DynamicActivityPropertyDescriptor always returns false for ShouldSerialize. So we ignore it.
            // A return value of Default just indicates that there was no ShouldSerialize method;
            // the caller can separately choose to process DesignerSerializationVisibilityAttribute.
            return ShouldSerializeResult.Default;
        }

        protected PropertyDescriptor GetDescriptor(object instance)
        {
            instance.CheckNotNull("instance");

            // DynamicActivity does not allow a PropertyDescriptor taken from one DA instance to
            // to be reused on another instance, even if they have the same definition.
            // So we need to invoke a descriptor from this particular instance.
            PropertyDescriptor result = null;
            ICustomTypeDescriptor typeDescriptor = instance as ICustomTypeDescriptor;
            if (typeDescriptor != null)
            {
                result = typeDescriptor.GetProperties()[Descriptor.Name];
            }
            if (result == null)
            {
                throw new ArgumentException("Must be an instance of DynamicActivity of type " + _xamlMember.DeclaringType.Name, "instance");
            }
            return result;
        }
    }
}

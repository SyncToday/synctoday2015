using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xaml;

namespace sync.today.workflow.wf.dyn.TypeDescription
{
    /// <summary>
    /// XamlSchemaContext implementation that provides XAML metadata based on System.ComponentModel's
    /// TypeDescriptor system, instead of directly from reflection.
    /// </summary>
    public class TypeDescriptorSchemaContext : XamlSchemaContext
    {
        private ConcurrentDictionary<Type, XamlType> _types = new ConcurrentDictionary<Type, XamlType>();

        public TypeDescriptorSchemaContext()
            : base()
        {
        }

        public TypeDescriptorSchemaContext(XamlSchemaContextSettings settings)
            : base(settings)
        {
        }

        public TypeDescriptorSchemaContext(IEnumerable<Assembly> referenceAssemblies)
            : base(referenceAssemblies)
        {
        }

        public TypeDescriptorSchemaContext(IEnumerable<Assembly> referenceAssemblies, XamlSchemaContextSettings settings)
            : base(referenceAssemblies, settings)
        {
        }

        public override XamlType GetXamlType(Type type)
        {
            type.CheckNotNull("type");
            XamlType result;
            if (!_types.TryGetValue(type, out result))
            {
                ICustomTypeDescriptor descriptor = GetTypeDescriptor(type);
                if (descriptor != null)
                {
                    result = new TypeDescriptorXamlType(type, this, descriptor);

                }
                if (!_types.TryAdd(type, result))
                {
                    result = _types[type];
                }
            }
            return result ?? base.GetXamlType(type);
        }

        protected virtual ICustomTypeDescriptor GetTypeDescriptor(Type type)
        {
            return TypeDescriptor.GetProvider(type).GetTypeDescriptor(type);
        }
    }
}

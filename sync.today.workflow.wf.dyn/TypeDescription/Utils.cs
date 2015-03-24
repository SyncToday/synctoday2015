using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xaml.Schema;

namespace sync.today.workflow.wf.dyn.TypeDescription
{
    /// <summary>
    /// Adapter from AttributeCollection to ICustomAttributeProvider
    /// </summary>
    public class CollectionAttributeProvider : ICustomAttributeProvider
    {
        public CollectionAttributeProvider(AttributeCollection collection)
        {
            collection.CheckNotNull("collection");
            Collection = collection;
        }

        public AttributeCollection Collection { get; private set; }

        // Note: even if inherit = false, TypeDescriptor returns all inherited attributes.
        // That is harmless in the XAML case.
        public object[] GetCustomAttributes(bool inherit)
        {
            return Collection.Cast<Attribute>().ToArray();
        }

        public object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return AttributesOfType(attributeType).ToArray();
        }

        public bool IsDefined(Type attributeType, bool inherit)
        {
            return AttributesOfType(attributeType).Any();
        }

        private IEnumerable<Attribute> AttributesOfType(Type attributeType)
        {
            return from a in Collection.Cast<Attribute>()
                   where attributeType.IsAssignableFrom(a.GetType())
                   select a;
        }
    }

    // The base implementation of XamlValueConverter expects to take a converter type, and create
    // an instance only if needed. This class allows us to use the converter instance that TypeDescriptor
    // already creates for us.
    internal class SpecifiedInstanceValueConverter : XamlValueConverter<TypeConverter>
    {
        TypeConverter _converter;

        public SpecifiedInstanceValueConverter(TypeConverter converter)
            : base(converter.GetType(), null)
        {
            _converter = converter;
        }

        protected override TypeConverter CreateInstance()
        {
            return _converter;
        }
    }

    internal static class Extension
    {
        internal static T CheckNotNull<T>(this T obj, string paramName) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
            return obj;
        }
    }

    internal static class ConverterHelper
    {
        // Exclude some of the built-in converters returned by System.ComponentModel which are not useful in XAML
        internal static bool IsNonXaml(TypeConverter converter)
        {
            Type converterType = converter.GetType();
            return converterType == typeof(TypeConverter) ||
                converterType == typeof(CollectionConverter) ||
                converterType == typeof(ArrayConverter) ||
                converterType == typeof(ExpandableObjectConverter) ||
                // Exclusion of ReferenceConverter here is tricky. None of the S.X components implement
                // IReferenceService, but a third-party component might, and there's no reason to block
                // ReferenceConverter from being used with XAML. The problem is that TypeDescriptor returns
                // its for all interfaces, which is not tenable in XAML.
                converterType == typeof(ReferenceConverter);
        }

        // Check for types which have built-in converters in XAML but have none or different
        // in System.ComponentModel
        internal static bool HasXamlSpecificBuiltInConverter(Type type)
        {
            if (type == null)
            {
                return false;
            }
            return type == typeof(object) ||
                typeof(Type).IsAssignableFrom(type) ||
                typeof(Type[]).IsAssignableFrom(type) ||
                typeof(DateTime) == type ||
                typeof(DateTimeOffset) == type ||
                typeof(Delegate).IsAssignableFrom(type);
        }
    }
}

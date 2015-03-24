using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;

namespace sync.today.workflow.wf.dyn.Activities
{
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

        internal static bool IsDynamicActivity(this Type type)
        {
            if (typeof(DynamicActivity).IsAssignableFrom(type))
            {
                return true;
            }
            // Can't directly cast to DynamicActivity<> so need to walk the type hierarchy
            var genericDynamicActivity = from t in type.SelfAndAncestors()
                                         where t.IsGenericType && t.GetGenericTypeDefinition() == typeof(DynamicActivity<>)
                                         select t;
            return genericDynamicActivity.Any();
        }

        internal static IEnumerable<Type> SelfAndAncestors(this Type type)
        {
            for (Type currentType = type; currentType != null; currentType = currentType.BaseType)
            {
                yield return currentType;
            }
        }
    }
}

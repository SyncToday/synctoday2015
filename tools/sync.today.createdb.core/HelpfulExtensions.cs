using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oak
{
    [DebuggerNonUserCode]
    public static class HelpfulExtensions
    {
        public static object ForEach(this object enumerable, Action<dynamic> action)
        {
            dynamic temp = enumerable;

            foreach (var item in temp) action(item);

            return enumerable;
        }

        public static object ForEach<T>(this object enumerable, Action<T> action)
        {
            dynamic temp = enumerable;

            foreach (var item in temp) action(item);

            return enumerable;
        }

        public static bool None<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }

}

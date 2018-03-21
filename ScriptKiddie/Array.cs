using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptKiddie
{
    public static class ScriptKiddieArray
    {
        // do something with each element, returns void
        public static void forEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (TSource item in source)
                action(item);
        }

        // do something with each element and its index, returns void
        public static void forEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
        {
            int index = 0;
            foreach (TSource item in source)
                action(item, index++);
        }

        // Chainable map function
        public static IEnumerable<TReturn> map<TSource, TReturn>(this IEnumerable<TSource> source, Func<TSource, TReturn> f)
        {
            foreach (TSource item in source)
                yield return f(item);
        }

        // Chainable map against function that takes item, index
        public static IEnumerable<TReturn> map<TSource, TReturn>(this IEnumerable<TSource> source, Func<TSource, int, TReturn> f)
        {
            int index = 0;
            foreach (TSource item in source)
            {
                yield return f(item, index);
                index++;
            }                
        }

        // Chainable filter
        public static IEnumerable<TSource> filter<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f)
        {
            foreach (TSource item in source)
                if (f(item))
                    yield return item;
        }

        // Chainable filter with index
        public static IEnumerable<TSource> filter<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f)
        {
            int index = 0;
            foreach (TSource item in source)
            {
                if (f(item, index))
                    yield return item;
                index++;
            }

        }
    }
}

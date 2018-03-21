using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptKiddie
{
    public static class ScriptKiddieArray
    {
        public static void forEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (TSource item in source)
                action(item);
        }

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

        public static IEnumerable<TReturn> map<TSource, TReturn>(this IEnumerable<TSource> source, Func<TSource, int, TReturn> f)
        {
            int index = 0;
            foreach (TSource item in source)
            {
                yield return f(item, index);
                index++;
            }                
        }
    }
}

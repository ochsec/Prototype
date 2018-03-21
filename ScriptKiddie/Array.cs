using System;
using System.Collections.Generic;

namespace ScriptKiddie
{
    public static class ScriptKiddieArray
    {
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

        // Returns first item that returns true from function
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f)
        {
            List<TSource> matches = new List<TSource>();
            foreach (TSource item in source)
            {
                if (f(item))
                {
                    matches.Add(item);
                    break;
                }                    
            }

            return matches[0];
        }

        // Returns first item that returns true from function that takes item, index
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f)
        {
            int index = 0;
            List<TSource> matches = new List<TSource>();
            foreach (TSource item in source)
            {
                if (f(item, index))
                {
                    matches.Add(item);
                    break;
                }
                index++;
            }

            return matches[0];
        }

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
    }
}

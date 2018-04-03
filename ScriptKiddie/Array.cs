using System;
using System.Collections.Generic;

namespace ScriptKiddie
{
    public static class ScriptKiddieArray
    {
        public static IEnumerable<TSource> concat<TSource>(this IEnumerable<TSource> source, IEnumerable<TSource> vector)
        {
            var list = new List<TSource>(source);
            list.AddRange(vector);
            return list as IEnumerable<TSource>;
        }

        public static bool every<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f)
        {
            bool result = true;
            foreach (TSource item in source)
                if (!f(item))
                    result = false;
            return result;
        }

        public static bool every<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f)
        {
            bool result = true;
            int index = 0;
            foreach (TSource item in source)
            {
                if (!f(item, index))
                    result = false;
                index++;
            }
            return result;
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

        // Returns first item that returns true from function
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f)
        {
            TSource match = default(TSource);
            foreach (TSource item in source)
            {
                if (f(item))
                {
                    match = item;
                    break;
                }                    
            }

            return match;
        }

        // Returns first item that returns true from function that takes item, index
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f)
        {
            int index = 0;
            TSource match = default(TSource);
            foreach (TSource item in source)
            {
                if (f(item, index))
                {
                    match = item;
                    break;
                }
                index++;
            }

            return match;
        }

        public static int findIndex<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f)
        {
            int index = -1;
            int counter = 0;
            foreach (TSource item in source)
            {
                if (f(item))
                {
                    index = counter;
                    break;
                }
                counter++;
            }
            return index;
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

        // Only returns the last item, does not remove from IEnumerable
        public static TSource pop<TSource>(this IEnumerable<TSource> source)
        {
            var stack = new Stack<TSource>(source);
            var last = stack.Pop();
            return last;
        }

        public static TSource reduce<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> f)
        {
            var acc = default(TSource);
            foreach(TSource item in source)
                acc = f(acc, item);

            return acc;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ScriptKiddie
{
    public static class ScriptKiddieArray
    {
        private static IEnumerable<Tuple<TSource, int>> ZipWithIndex<TSource>(this IEnumerable<TSource> source) => source.Select((x, i) => Tuple.Create(x, i));

        public static IEnumerable<TSource> concat<TSource>(this IEnumerable<TSource> source, IEnumerable<TSource> vector) => source.Concat(vector);

        public static bool every<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f) => source.All(f);

        public static bool every<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f) => source.ZipWithIndex().All(x => f(x.Item1, x.Item2));

        public static IEnumerable<TSource> filter<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f) => source.Where(f);

        // Chainable filter with index
        public static IEnumerable<TSource> filter<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f) => source.Where(f);

        // Returns first item that returns true from function
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> f) => source.FirstOrDefault(f);

        // Returns first item that returns true from function that takes item, index
        public static TSource find<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> f) => source.Where(f).FirstOrDefault();

        // do something with each element, returns void
        public static void forEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action) {
            foreach (TSource item in source)
                action(item);
        }

        // do something with each element and its index, returns void
        public static void forEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action) {
            int index = 0;
            foreach (TSource item in source)
                action(item, index++);
        }

        // Chainable map function
        public static IEnumerable<TReturn> map<TSource, TReturn>(this IEnumerable<TSource> source, Func<TSource, TReturn> f) => source.Select(f);
        // Chainable map against function that takes item, index
        public static IEnumerable<TReturn> map<TSource, TReturn>(this IEnumerable<TSource> source, Func<TSource, int, TReturn> f) => source.Select(f);

        // Only returns the last item, does not remove from IEnumerable
        public static TSource pop<TSource>(this IEnumerable<TSource> source) => source.Last();

        public static TSource reduce<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> f) => source.Aggregate(f);
    }
}
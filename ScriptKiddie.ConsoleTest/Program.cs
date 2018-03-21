using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptKiddie;

namespace ScriptKiddie.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            array.forEach(item => Console.WriteLine(item));

            List<string> list = new List<string>()
            {
                "a", "b", "c"
            };

            string concat = string.Empty;
            list.forEach(str =>
            {
                concat += str;
            });
            Console.WriteLine(concat);

            list.forEach((str, index) => Console.WriteLine($"Index: {index}, Value: {str}"));

            var newEnumerable = array.map(x => timesTwo(x)).ToList();
            foreach (int num in newEnumerable)
            {
                Console.WriteLine(num);
            }

            var newIndexedEnumerable = array.map((x, i) => timesTwoPlusIndex(x, i)).ToList();
            foreach (int num in newIndexedEnumerable)
            {
                Console.WriteLine(num);
            }

            var evenCollection = array.filter(x => x % 2 == 0);
            foreach (var num in evenCollection)
            {
                Console.WriteLine(num);
            }

            var evenIndexedCollection = array.filter(indexGreaterThanTwo);
            foreach (var num in evenIndexedCollection)
            {
                Console.WriteLine(num);
            }
        }

        public static int timesTwo(int x)
        {
            return x * 2;
        }

        public static int timesTwoPlusIndex(int x, int i)
        {
            return x * 2 + 1;
        }

        public static bool indexGreaterThanTwo(int item, int index)
        {
            return index > 2;
        }
    }
}

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
            Filter_Array_Times_Index_Modulo_Three();
            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //array.forEach(item => Console.WriteLine(item));

            //List<string> list = new List<string>()
            //{
            //    "a", "b", "c"
            //};

            //string concat = string.Empty;
            //list.forEach(str =>
            //{
            //    concat += str;
            //});
            //Console.WriteLine(concat);

            //list.forEach((str, index) => Console.WriteLine($"Index: {index}, Value: {str}"));

            //var newEnumerable = array.map(x => timesTwo(x)).ToList();
            //foreach (int num in newEnumerable)
            //{
            //    Console.WriteLine(num);
            //}

            //var newIndexedEnumerable = array.map((x, i) => timesTwoPlusIndex(x, i)).ToList();
            //foreach (int num in newIndexedEnumerable)
            //{
            //    Console.WriteLine(num);
            //}

            //var evenCollection = array.filter(x => x % 2 == 0);
            //foreach (var num in evenCollection)
            //{
            //    Console.WriteLine(num);
            //}

            //var evenIndexedCollection = array.filter(indexGreaterThanTwo).Take(2);
            //foreach (var num in evenIndexedCollection)
            //{
            //    Console.WriteLine(num);
            //}

            //var foundItem = array.find(x => x == 2);
            //Console.WriteLine(foundItem);

            //var foundItemWithIndex = array.find((x, i) => x * i > 4);
            //Console.WriteLine(foundItemWithIndex);
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

        public static void Filter_Array_Times_Index_Modulo_Three()
        {
            int[] ints = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            var subset = ints.filter((x, i) => (x * i) % 3 == 0);
            foreach (int num in subset)
            {
                Console.WriteLine(num);
            }
        }
    }
}

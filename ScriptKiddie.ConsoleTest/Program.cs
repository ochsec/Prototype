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

            var newArray = array.map(x => timesTwo(x)).ToList();
            foreach (int num in newArray)
            {
                Console.WriteLine(num);
            }

            var newIndexedArray = array.map((x, i) => timesTwoPlusIndex(x, i)).ToList();
            foreach (int num in newIndexedArray)
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
    }
}

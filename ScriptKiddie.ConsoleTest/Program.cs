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
        }
    }
}

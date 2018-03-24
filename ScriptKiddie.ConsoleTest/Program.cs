using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptKiddie;
using ScriptKiddie.Test;

namespace ScriptKiddie.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var filterTester = new FilterTests();
            filterTester.RunTests();
        }
    }
}

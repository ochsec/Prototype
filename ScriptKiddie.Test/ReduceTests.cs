using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptKiddie;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class ReduceTests
    {
        public void RunTests()
        {
            Reduce_Integer_Array();
            Reduce_List_Of_Strings();
        }

        [TestMethod]
        public void Reduce_Integer_Array()
        {
            // arrange
            int[] arr = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            // act
            int result = arr.reduce((x, y) => x + y);

            // assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Reduce_List_Of_Strings()
        {
            // arrange
            var list = new List<string> { "a", "b", "c", "d" };

            // act
            string result = list.reduce((x, y) => x + y);

            // assert
            Assert.AreEqual("abcd", result);
        }
    }
}

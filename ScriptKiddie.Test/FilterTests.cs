using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptKiddie;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void Filter_Integer_Array_Even()
        {
            // arrange
            int[] ints = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // act
            var evens = ints.filter(x => x % 2 == 0);

            // assert
            Assert.IsTrue(evens.SequenceEqual(new[] { -4, -2, 0, 2, 4 }));
        }

        [TestMethod]
        public void Filter_Integer_Array_Times_Index_Multiple_Of_Three()
        {
            // arrange
            int[] ints = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // act
            var subset = ints.filter((x, i) => (x * i) % 3 == 0);

            // assert
            Assert.IsTrue(subset.SequenceEqual(new[] { -5, -3, -2, 0, 1, 3, 4 }));
        }

        [TestMethod]
        public void Filter_Strings_By_Substring_Chained()
        {
            // arrange
            string[] arr = { "aa", "ab", "ac", "ba", "bb", "bc", "ca", "cb", "cc" };

            // act
            var subset = arr.filter(s => s.Contains("a")).filter(s => s.Contains("c"));

            // assert
            Assert.IsTrue(subset.SequenceEqual(new[] { "ac", "ca" }));
        }
    }
}

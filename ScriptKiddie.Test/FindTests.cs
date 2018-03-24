using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptKiddie;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void Find_Matching_String()
        {
            // arrange
            var list = new List<string> { "foo", "bar", "baz", "bar", "baz", "foo" };

            // act
            var result = list.find(s => s == "baz");

            // assert
            Assert.AreEqual("baz", result);
        }

        [TestMethod]
        public void Find_String_By_Index()
        {
            // arrange
            var list = new List<string> { "foo", "bar", "baz", "bar", "baz", "foo" };

            // act
            var result = list.find((s, i) => i == 3);

            // assert
            Assert.AreEqual("bar", result);
        }
    }
}

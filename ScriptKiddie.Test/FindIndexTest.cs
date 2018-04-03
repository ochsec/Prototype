using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class FindIndexTest
    {
        [TestMethod]
        public void Find_Index_String_Array()
        {
            // arrange
            string[] arr = new string[] { "a", "a", "b", "b", "c", "c" };

            // act
            var index = arr.findIndex(str => str == "b");

            // assert
            Assert.AreEqual(2, index);
        }
    }
}

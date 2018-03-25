using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptKiddie;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class ConcatTests
    {
        [TestMethod]
        public void Contatenate_Char_Arrays()
        {
            // arrange
            char[] chars1 = new char[] { 'a', 'b', 'c' };
            char[] chars2 = new char[] { 'x', 'y', 'z' };

            // act
            var concat = chars1.concat(chars2);

            // assert
            Assert.IsTrue(concat.SequenceEqual(new[] { 'a', 'b', 'c', 'x', 'y', 'z' }));
        }
    }
}

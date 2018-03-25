using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScriptKiddie.Test
{
    [TestClass]
    public class EveryTests
    {
        [TestMethod]
        public void Every_Number_Is_Even()
        {
            // arrange
            int[] nums = new int[] { 2, 4, 6, 8, 10 };

            // act
            bool result = nums.every(x => x % 2 == 0);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Every_Number_Is_Not_Even()
        {
            // arrange
            int[] nums = new int[] { 2, 4, 7, 8, 10 };

            // act
            bool result = nums.every(x => x % 2 == 0);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Every_Index_Multiple_Is_Positive()
        {
            // arrange
            int[] nums = new int[] { 1, 2, 3 };

            // act
            bool result = nums.every(x => x > 0);

            // assert
            Assert.IsTrue(result);
        }
    }
}

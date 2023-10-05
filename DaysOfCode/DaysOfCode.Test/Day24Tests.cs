using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day24Tests
    {
        [TestMethod]
        public void DaysOfCode24_Array123_ArrayLengthOne()
        {
            //Arrange
            DaysOfCode24 Test1 = new DaysOfCode24();
            int[] input = new int[] { 1 };

            //Act
            bool result = Test1.Array123(input);

            //Assert
            Assert.AreEqual(false, result, "An array under length of three should always return false");
        }

        [TestMethod]
        public void DaysOfCode24_Array123_LongArrayWith123()
        {
            //Arrange
            DaysOfCode24 Test2 = new DaysOfCode24();
            int[] input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Act
            bool result = Test2.Array123(input);

            //Assert
            Assert.AreEqual(true, result, "If nums contains 1, 2, and 3 consecutively anywhere in the array it should return true");
        }

        [TestMethod]
        public void DaysOfCode24_Array123_LongArrayWithout123()
        {
            //Arrange
            DaysOfCode24 Test3 = new DaysOfCode24();
            int[] input = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16 };

            //Act
            bool result = Test3.Array123(input);

            //Assert
            Assert.AreEqual(false, result, "If nums does not contain 1, 2, and 3 consecutively anywhere in the array it should return false");
        }
    }
}

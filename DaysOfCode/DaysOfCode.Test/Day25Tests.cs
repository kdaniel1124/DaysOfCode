using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day25Tests
    {
        [TestMethod]
        public void DaysOfCode25_IsStrictlyIncreasing_EmptyArray()
        {
            //Arrange
            DaysOfCode25 Test1 = new DaysOfCode25();
            int[] input = new int[0];

            //Act
            bool result = Test1.IsStrictlyIncreasing(input);

            //Assert
            Assert.AreEqual(false, result, "If an array is empty then it is not increasing and the method should always return false");

        }

        [TestMethod]
        public void DaysOfCode25_IsStrictlyIncreasing_NegativeArray()
        {
            //Arrange
            DaysOfCode25 Test2 = new DaysOfCode25();
            int[] input = new int[] {-10, -8, -6, -4, -2, 0};

            //Act
            bool result = Test2.IsStrictlyIncreasing(input);

            //Assert
            Assert.AreEqual(true, result, "If an array is empty then it is not increasing and the method should always return false");

        }

        [TestMethod]
        public void DaysOfCode25_IsStrictlyIncreasing_EndingWithDecrease()
        {
            //Arrange
            DaysOfCode25 Test3 = new DaysOfCode25();
            int[] input = new int[] {1, 2, 3, 4, 5, 4};

            //Act
            bool result = Test3.IsStrictlyIncreasing(input);

            //Assert
            Assert.AreEqual(false, result, "If the array decreases at any poit  then the method should return false");

        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day16Tests
    {
        [TestMethod]
        public void DaysOfCode16_FizzArray_ArrayLengthTen()
        {
            //Arrange
            DaysOfCode16 Test1 = new DaysOfCode16();
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int input = 10;

            //Act
            int[] result = Test1.FizzArray(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should return an int array of all numbers leading up (but not including) to the input, num");
        }

        [TestMethod]
        public void DaysOfCode16_FizzArray_NegativeNumInput()
        {
            //Arrange
            DaysOfCode16 Test2 = new DaysOfCode16();
            int[] expected = new int[] { };
            int input = -5;

            //Act
            int[] result = Test2.FizzArray(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "If input num is negative then the method should return an empty int array");
        }

        [TestMethod]
        public void DaysOfCode16_FizzArray_EmptyArray()
        {
            //Arrange
            DaysOfCode16 Test3 = new DaysOfCode16();
            int[] expected = new int[] { };
            int input = 0;

            //Act
            int[] result = Test3.FizzArray(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "If input num is zero then the method should return an empty int array");
        }

    }
}

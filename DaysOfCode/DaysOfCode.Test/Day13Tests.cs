using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day13Tests
    {
        [TestMethod]
        public void DaysOfCode13_MakeEnds_NegativeSwap()
        {
            //Arrange
            DaysOfCode13 Test1 = new DaysOfCode13();
            int[] input = new int[] { -1, 0, 1 };
            int[] expected = new int[] { -1, 1 };

            //Act
            int[] result = Test1.MakeEnds(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should return an array with swapped the beginning and end indexes and drop the numbers in between");
        }

        [TestMethod]
        public void DaysOfCode13_MakeEnds_ArrayLengthOne()
        {
            //Arrange
            DaysOfCode13 Test2 = new DaysOfCode13();
            int[] input = new int[] { 42 };
            int[] expected = new int[] { 42, 42 };

            //Act
            int[] result = Test2.MakeEnds(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "If array has a length of one then it should return the number twice in an array");
        }

        [TestMethod]
        public void DaysOfCode13_MakeEnds_LongArrayRandomOrder()
        {
            //Arrange
            DaysOfCode13 Test3 = new DaysOfCode13();
            int[] input = new int[] { 65, 3, -5, 12, -900, -27, 27, -64, 16 };
            int[] expected = new int[] { 65, 16 };

            //Act
            int[] result = Test3.MakeEnds(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Should return an array of length two regardless of original array length or contents");
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day11Test
    {
        [TestMethod]
        public void DaysOfCode11_MakeMiddle_LengthOfSix()
        {
            //arrange
            DaysOfCode11 Test1 = new DaysOfCode11();
            int[] input = new int[] { 1, 2, 3, 4, 5, 6};
            int[] expected = new int[] { 3, 4};

            //act
            int[] result = Test1.MakeMiddle(input);

            //assert
            CollectionAssert.AreEqual(expected, result, "Method should return only the two middle numbers");
        }

        [TestMethod]
        public void DaysOfCode11_MakeMiddle_LengthOfTwo()
        {
            //arrange
            DaysOfCode11 Test1 = new DaysOfCode11();
            int[] input = new int[] { 5, 6};
            int[] expected = new int[] { 5, 6};

            //act
            int[] result = Test1.MakeMiddle(input);

            //assert
            CollectionAssert.AreEqual(expected, result, "if original array is only length of two then method should return the whole array");
        }

        [TestMethod]
        public void DaysOfCode11_MakeMiddle_LongArray()
        {
            //arrange
            DaysOfCode11 Test1 = new DaysOfCode11();
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int[] expected = new int[] { 10, 11};

            //act
            int[] result = Test1.MakeMiddle(input);

            //assert
            CollectionAssert.AreEqual(expected, result, "Method should return only the two middle numbers regardless of array length");
        }

    }
}

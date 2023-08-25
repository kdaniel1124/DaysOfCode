using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day12Tests
    {
        [TestMethod]
        public void DaysOfCode12_MakeLast_ThreeOnes()
        {
            //Arrange
            DaysOfCode12 Test1 = new DaysOfCode12();
            int[] input = new int[] { 1, 1, 1};
            int[] expected = new int[] { 0, 0, 0, 0, 0, 1};

            //Act
            int[] result = Test1.MakeLast(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should return array populated with zeros except the last character");
        }

        [TestMethod]
        public void DaysOfCode12_MakeLast_LengthOfOne()
        {
            //Arrange
            DaysOfCode12 Test2 = new DaysOfCode12();
            int[] input = new int[] { 10 };
            int[] expected = new int[] { 0, 10 };

            //Act
            int[] result = Test2.MakeLast(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method shoudl return an array twice the length of the original");
        }

        [TestMethod]
        public void DaysOfCode12_MakeLast_LongArray()
        {
            //Arrange
            DaysOfCode12 Test3 = new DaysOfCode12();
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] expected = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9};

            //Act
            int[] result = Test3.MakeLast(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should return an array doubled in length and populated with zeros except the last character");
        }

    }
}

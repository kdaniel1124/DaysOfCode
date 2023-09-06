using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day17Tests
    {
        [TestMethod]
        public void DaysOfCode17_Fix23_EndsWith23()
        {
            //Arrange
            DaysOfCode17 Test1 = new DaysOfCode17();
            int[] input = new int[] { 1, 3, 4, 2, 5, 2, 3};
            int[] expected = new int[] { 1, 3, 4, 2, 5, 2, 0};

            //Act
            int[] result = Test1.Fix23(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should only 'fix' 3's that are immediately preceeded by 2's");
        }

        [TestMethod]
        public void DaysOfCode17_Fix23_No2sOr3s()
        {
            //Arrange
            DaysOfCode17 Test2 = new DaysOfCode17();
            int[] input = new int[] { 1, 5, 4, 7, 5, 10, 0};
            int[] expected = new int[] { 1, 5, 4, 7, 5, 10, 0};

            //Act
            int[] result = Test2.Fix23(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "With no 2's or 3's the array should simply be returned unchanged");
        }

        [TestMethod]
        public void DaysOfCode17_Fix23_ArrayOfLength1()
        {
            //Arrange
            DaysOfCode17 Test3 = new DaysOfCode17();
            int[] input = new int[] { 3 };
            int[] expected = new int[] {3 };

            //Act
            int[] result = Test3.Fix23(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "An array with only one element should always be returned unchanged");
        }

    }

}

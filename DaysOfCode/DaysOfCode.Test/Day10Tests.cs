using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day10Tests
    {
        [TestMethod]
        public void DaysOfCode10_More14_EmptyArray()
        {
            //Arrange
            DaysOfCode10 Test1 = new DaysOfCode10();
            int[] input = new int[] { };

            //Act
            bool result = Test1.More14(input);

            //Assert
            Assert.AreEqual(false, result, "An empty array should return false because there are not more ones than fours");
        }

        [TestMethod]
        public void DaysOfCode10_More14_MoreOnes()
        {
            //Arrange
            DaysOfCode10 Test1 = new DaysOfCode10();
            int[] input = new int[] { 1, 4, 3, 1, 3, 2, 1, 4};

            //Act
            bool result = Test1.More14(input);

            //Assert
            Assert.AreEqual(true, result, "The method should return true if there are more ones than fours");
        }

        [TestMethod]
        public void DaysOfCode10_More14_NoOnesOrFours()
        {
            //Arrange
            DaysOfCode10 Test3 = new DaysOfCode10();
            int[] input = new int[] { 2, 3, 5, 6, 7};

            //Act
            bool result = Test3.More14(input);

            //Assert
            Assert.AreEqual(false, result, "An array with no ones or fours should return flase because there are not more ones than fours");
        }

    }
}

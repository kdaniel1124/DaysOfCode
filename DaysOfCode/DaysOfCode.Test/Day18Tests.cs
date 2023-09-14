using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day18Tests
    {
        [TestMethod]
        public void DaysOfCode18_EvenlySpaced_SpacedByOne()
        {
            //Arrange
            DaysOfCode18 Test1 = new DaysOfCode18();
            bool expected = true;

            //Act
            bool result = Test1.EvenlySpaced(5, 4, 6);

            //Assert
            Assert.AreEqual(expected, result, "method should return true if small medium and large numbers are evenly spaced");
        }

        [TestMethod]
        public void DaysOfCode18_EvenlySpaced_NegativeNumbers()
        {
            //Arrange
            DaysOfCode18 Test1 = new DaysOfCode18();
            bool expected = true;

            //Act
            bool result = Test1.EvenlySpaced(-10, -7, -13);

            //Assert
            Assert.AreEqual(expected, result, "method should return true if small medium and large numbers (regardless of their order or value) are evenly spaced");
        }

        [TestMethod]
        public void DaysOfCode18_EvenlySpaced_IngloriousBastardsTest()
        {
            //Arrange
            DaysOfCode18 Test3 = new DaysOfCode18();
            bool expected = true;

            //Act
            bool result = Test3.EvenlySpaced(9, 9, 9);

            //Assert
            Assert.AreEqual(expected, result, "method should return true when all three numbers are the same because they are evenly spaced");
        }
        [TestMethod]
        public void DaysOfCode18_EvenlySpaced_NotEven()
        {
            //Arrange
            DaysOfCode18 Test4 = new DaysOfCode18();
            bool expected = false;

            //Act
            bool result = Test4.EvenlySpaced(0, 2, 0);

            //Assert
            Assert.AreEqual(expected, result, "method should return false if small medium and large numbers are not evenly spaced between each other");
        }
    }
}

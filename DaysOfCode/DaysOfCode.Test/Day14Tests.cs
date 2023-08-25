using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day14Tests
    {
        [TestMethod]
        public void DaysOfCode14_LessBy10_ThreeOfSameNumber()
        {
            //Arrange
            DaysOfCode14 Test1 = new DaysOfCode14();

            //Act
            bool result = Test1.LessBy10(10, 10, 10);

            //Assert
            Assert.AreEqual(false, result, "Three of the same number have no difference and therefore should return false");
        }

        [TestMethod]
        public void DaysOfCode14_LessBy10_NegativeNumbersTest()
        {
            //Arrange
            DaysOfCode14 Test2 = new DaysOfCode14();

            //Act
            bool result = Test2.LessBy10(-20, -21, 10);

            //Assert
            Assert.AreEqual(true, result, "Difference of 31 between 10 and -21 should return true");
        }

        [TestMethod]
        public void DaysOfCode14_LessBy10_DifferenceOfTen()
        {
            //Arrange
            DaysOfCode14 Test3 = new DaysOfCode14();

            //Act
            bool result = Test3.LessBy10(0, 5, 10);

            //Assert
            Assert.AreEqual(true, result, "A difference of exactly ten should return true");

        }
    }
}

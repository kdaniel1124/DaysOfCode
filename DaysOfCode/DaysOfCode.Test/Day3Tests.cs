using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        public void DaysOfCode3_GreenTicket_ThreeOfTheSameNumber()
        {
            //Arrange
            DaysOfCode3 Test1 = new DaysOfCode3();
            int expected = 20;

            //Act
            int result = Test1.GreenTicket(1, 1, 1);

            //Assert
            Assert.AreEqual(expected, result, "Getting three of the same number should result in a prize of 20");
        }

        [TestMethod]
        public void DaysOfCode3_GreenTicket_NoMatchingNumbers()
        {
            //Arrange
            DaysOfCode3 Test2 = new DaysOfCode3();
            int expected = 0;

            //Act
            int result = Test2.GreenTicket(2, 1, 3);

            //Assert
            Assert.AreEqual(expected, result, "No matching numbers should result in a prize of 0");
        }

        [TestMethod]
        public void DaysOfCode3_GreenTicket_TwoMatchingNumbers()
        {
            //Arrange
            DaysOfCode3 Test3 = new DaysOfCode3();
            int expected = 10;

            //Act
            int result = Test3.GreenTicket(1, 2, 1);

            //Assert
            Assert.AreEqual(expected, result, "Only two matching numbers should result in a prize of 10");
        }
    }
}

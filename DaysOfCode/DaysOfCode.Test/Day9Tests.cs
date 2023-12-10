using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day9Tests
    {
        [TestMethod]
        public void DaysOfCode9_No14_OneAtEnd()
        {
            //Arrange
            DaysOfCode9 Test1 = new DaysOfCode9();
            int[] input = { 3, 3, 5, 6, 9, 1 };
            bool expected = false;

            //Act
            bool result = Test1.No14(input);

            //Assert
            Assert.AreEqual(expected, result, "If array has a 1 or a 4 method should return false.");
        }

        [TestMethod]
        public void DaysOfCode9_No14_MiddleFours()
        {
            //Arrange
            DaysOfCode9 Test1 = new DaysOfCode9();
            int[] input = { 2, 3, 4, 4, 5, 6 };
            bool expected = false;

            //Act
            bool result = Test1.No14(input);

            //Assert
            Assert.AreEqual(expected, result, "If array has a 1 or a 4 method should return false.");
        }

        [TestMethod]
        public void DaysOfCode9_No14_Fourteen()
        {
            //Arrange
            DaysOfCode9 Test3 = new DaysOfCode9();
            int[] input = { 3, 5, 14, 6, 9, 8 };
            bool expected = true;

            //Act
            bool result = Test3.No14(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should only return false for 1 OR 4, not triggering on 14, 146, etc.");
        }

        [TestMethod]
        public void DaysOfCode9_No14_NoTriggers()
        {
            //Arrange
            DaysOfCode9 Test4 = new DaysOfCode9();
            int[] input = { 20, 300, 59 };
            bool expected = true;

            //Act
            bool result = Test4.No14(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should only return false if the array contains 1 or 4, otherwise it shoudl return true.");
        }

    }
}

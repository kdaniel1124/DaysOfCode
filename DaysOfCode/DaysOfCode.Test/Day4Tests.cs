using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        public void DaysOfCode4_Start1_BothOnes()
        {
            //Arrange
            DaysOfCode4 Test1 = new DaysOfCode4();
            int[] inputA = { 1, 2, 3, 2, 1};
            int[] inputB = { 1, 2, 3, 2, 1};
            int expected = 2;

            //Act
            int result = Test1.Start1(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should assess whether or not each array starts with a 1, then return the number of arrays that do.");
        }

        [TestMethod]
        public void DaysOfCode4_Start1_NoOnes()
        {
            //Arrange
            DaysOfCode4 Test2 = new DaysOfCode4();
            int[] inputA = { 2, 3, 2, 1};
            int[] inputB = { 3, 2, 1};
            int expected = 0;

            //Act
            int result = Test2.Start1(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should assess whether or not each array starts with a 1, then return the number of arrays that do.");
        }

        [TestMethod]
        public void DaysOfCode4_Start1_EmptyArray()
        {
            //Arrange
            DaysOfCode4 Test1 = new DaysOfCode4();
            int[] inputA = { 1, 2, 1};
            int[] inputB = { };
            int expected = 1;

            //Act
            int result = Test1.Start1(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should assess whether or not each array starts with a 1, then return the number of arrays that do.");
        }

    }
}

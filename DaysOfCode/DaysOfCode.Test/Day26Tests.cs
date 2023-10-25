using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day26Tests
    {
        [TestMethod]
        public void DaysOfCode26_SumOdds_NoParameters()
        {
            //Arrange
            DaysOfCode26 Test1 = new DaysOfCode26();
            int expected = 2500;

            //Act
            int result = Test1.SumOdds();

            //Assert
            Assert.AreEqual(expected, result, "With no parameters given the method should sum up all odd numbers starting at 1 and going up to 100, resulting in, and returning 2500");
        }

        [TestMethod]
        public void DaysOfCode26_SumOdds_OneParameter()
        {
            //Arrange
            DaysOfCode26 Test2 = new DaysOfCode26();
            int input = 500;
            int expected = 62500;

            //Act
            int result = Test2.SumOdds(input);

            //Assert
            Assert.AreEqual(expected, result, "With one parameter given the method should sum up all odd numbers starting at 1 and going up to the user provided number, returning the answer");
        }

        [TestMethod]
        public void DaysOfCode26_SumOdds_TwoParameters()
        {
            //Arrange
            DaysOfCode26 Test3 = new DaysOfCode26();
            int inputStart = 6;
            int inputEnd = 50;
            int expected = 616;

            //Act
            int result = Test3.SumOdds(inputStart, inputEnd);

            //Assert
            Assert.AreEqual(expected, result, "With two parameters given the method should sum up all odd numbers starting at the first user provided number and going up to the second user provided number, returning the answer");
        }

    }
}

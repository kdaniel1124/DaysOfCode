using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day32Tests
    {
        [TestMethod]
        public void DaysOfCode32_Factorial_ZeroTest()
        {
            //Arrange
            DaysOfCode32 Test1 = new DaysOfCode32();
            int input = 0;
            int expected = 0;

            //Act
            int result = Test1.Factorial(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DaysOfCode32_Factorial_OneTest()
        {
            //Arrange
            DaysOfCode32 Test2 = new DaysOfCode32();
            int input = 1;
            int expected = 1;

            //Act
            int result = Test2.Factorial(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DaysOfCode32_Factorial_FourTest()
        {
            //Arrange
            DaysOfCode32 Test3 = new DaysOfCode32();
            int input = 4;
            int expected = 24;

            //Act
            int result = Test3.Factorial(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DaysOfCode32_Factorial_TenTest()
        {
            //Arrange
            DaysOfCode32 Test4 = new DaysOfCode32();
            int input = 10;
            int expected = 3628800;

            //Act
            int result = Test4.Factorial(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}

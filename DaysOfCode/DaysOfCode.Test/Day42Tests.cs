using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day42Tests
    {
        [TestMethod]
        public void DaysOfCode42_DoubleX_EmptyString()
        {
            //Arrange
            DaysOfCode42 Test1 = new DaysOfCode42();
            string input = "";

            //Act
            bool result = Test1.DoubleX(input);

            //Assert
            Assert.IsFalse(result, "If input is empty, then method should return false");
        }

        [TestMethod]
        public void DaysOfCode42_DoubleX_CapitalAndLowerX()
        {
            //Arrange
            DaysOfCode42 Test2 = new DaysOfCode42();
            string input = "dasXxb";

            //Act
            bool result = Test2.DoubleX(input);

            //Assert
            Assert.IsTrue(result, "Method should return true if the first instance of 'x' is immediately followed by another 'x' (case insensitive)");
        }

        [TestMethod]
        public void DaysOfCode42_DoubleX_DoubleXNotFirstX()
        {
            //Arrange
            DaysOfCode42 Test1 = new DaysOfCode42();
            string input = "lxasdanXX";

            //Act
            bool result = Test1.DoubleX(input);

            //Assert
            Assert.IsFalse(result, "Method should return false if the first instance of 'x' is not immediately followed by another 'x' (case insensitive)");
        }

    }
}

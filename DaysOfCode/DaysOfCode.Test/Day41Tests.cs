using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day41Tests
    {
        [TestMethod]
        public void DaysOfCode41_CountXX_TriggerAtEnd()
        {
            //Arrange
            DaysOfCode41 Test1 = new DaysOfCode41();
            string input = "abcdefxx";
            int expected = 1;

            //Act
            int result = Test1.CountXX(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should count every time there is an 'x' with another 'x' after it");
        }

        [TestMethod]
        public void DaysOfCode41_CountXX_NoX()
        {
            //Arrange
            DaysOfCode41 Test2 = new DaysOfCode41();
            string input = "there are no ekses";
            int expected = 0;

            //Act
            int result = Test2.CountXX(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the amount of times there is an 'x' with another 'x' after it, if there are no 's then it shoudl simply return 0");
        }

        [TestMethod]
        public void DaysOfCode41_CountXX_AllX()
        {
            //Arrange
            DaysOfCode41 Test3 = new DaysOfCode41();
            string input = "xxxxxx";
            int expected = 5;

            //Act
            int result = Test3.CountXX(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should count every time there is an 'x' with another 'x' after it. ex: in the string 'xxx' that occurs twice");
        }

    }
}

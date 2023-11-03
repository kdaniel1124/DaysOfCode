using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day39Tests
    {
        [TestMethod]
        public void DaysOfCode39_ExtraEnd_LongWordTest()
        {
            //Arrange
            DaysOfCode39 Test1 = new DaysOfCode39();
            string input = "September is a swell month!";
            string expected = "h!h!h!";

            //Act
            string result = Test1.ExtraEnd(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should grab the last 2 characters of the string and return it three times in a row");
        }

        [TestMethod]
        public void DaysOfCode39_ExtraEnd_EmptyString()
        {
            //Arrange
            DaysOfCode39 Test2 = new DaysOfCode39();
            string input = "";
            string expected = "";

            //Act
            string result = Test2.ExtraEnd(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an empty string then method should simply return an empty string");
        }

        [TestMethod]
        public void DaysOfCode39_ExtraEnd_StringLengthOne()
        {
            //Arrange
            DaysOfCode39 Test3 = new DaysOfCode39();
            string input = "3";
            string expected = "333";

            //Act
            string result = Test3.ExtraEnd(input);

            //Assert
            Assert.AreEqual(expected, result, "If string is only length 1 then simply return what is there three times");
        }

    }
}

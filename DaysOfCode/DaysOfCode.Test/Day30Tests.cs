using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day30Tests
    {
        [TestMethod]
        public void DaysOfCode30_ReverseString_RacecarsReversal()
        {
            //Arrange
            DaysOfCode30 Test1 = new DaysOfCode30();
            string input = "racecars";
            string expected = "sracecar";

            //Act 
            string result = Test1.ReverseString(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should take in a string and return that string ordered from it's last index to it first");

        }

        [TestMethod]
        public void DaysOfCode30_ReverseString_EmptyString()
        {
            //Arrange
            DaysOfCode30 Test2 = new DaysOfCode30();
            string input = "";
            string expected = "";

            //Act 
            string result = Test2.ReverseString(input);

            //Assert
            Assert.AreEqual(expected, result, "The reverse of an empty string is an empty string");

        }

        [TestMethod]
        public void DaysOfCode30_ReverseString_LongStringTest()
        {
            //Arrange
            DaysOfCode30 Test3 = new DaysOfCode30();
            string input = "I oft reverse strings on the daily";
            string expected = "yliad eht no sgnirts esrever tfo I";

            //Act 
            string result = Test3.ReverseString(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should take in a string and return that string ordered from it's last index to it first, regardless of length");

        }

    }
}

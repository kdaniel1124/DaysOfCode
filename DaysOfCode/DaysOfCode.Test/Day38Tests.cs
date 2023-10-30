using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day38Tests
    {
        [TestMethod]
        public void DaysOfCode38_FirstHalf_PokeTest()
        {
            //Arrange
            DaysOfCode38 Test1 = new DaysOfCode38();
            string input = "poke";
            string expected = "po";

            //Act
            string result = Test1.FirstHalf(input);

            //Assert
            Assert.AreEqual(expected, result, "Given a tring of even length the method should return only the first half of the string");
        }

        [TestMethod]
        public void DaysOfCode38_FirstHalf_EmptyString()
        {
            //Arrange
            DaysOfCode38 Test2 = new DaysOfCode38();
            string input = "";
            string expected = "";

            //Act
            string result = Test2.FirstHalf(input);

            //Assert
            Assert.AreEqual(expected, result, "Half of zero is still zero. If provided an empty string method should simply return an empty string");
        }

        [TestMethod]
        public void DaysOfCode38_FirstHalf_LongTest()
        {
            //Arrange
            DaysOfCode38 Test3 = new DaysOfCode38();
            string input = "papa goes to the store";
            string expected = "papa goes t";

            //Act
            string result = Test3.FirstHalf(input);

            //Assert
            Assert.AreEqual(expected, result, "Given a tring of any even length the method should return the first half");
        }

    }
}

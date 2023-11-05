using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class CWJadenCasedTests
    {
        [TestMethod]
        public void CodeWarsJadenCased_ToJadenCase_EmptyString()
        {
            //Arrange
            CWJadenCased Test1 = new CWJadenCased();
            string input = "";
            string expected = "";

            //Act
            string result = Test1.ToJadenCase(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an empty string then no changes need to be made and the method should simply return an empty string");

        }

        [TestMethod]
        public void CodeWarsJadenCased_ToJadenCase_LongStringToBeJadened()
        {
            //Arrange
            CWJadenCased Test2 = new CWJadenCased();
            string input = "oh yes my name is jaden indeed";
            string expected = "Oh Yes My Name Is Jaden Indeed";

            //Act
            string result = Test2.ToJadenCase(input);

            //Assert
            Assert.AreEqual(expected, result, "When provided a string method should return the string with each word capitalized");

        }

        [TestMethod]
        public void CodeWarsJadenCased_ToJadenCase_AlreadyJadenCase()
        {
            //Arrange
            CWJadenCased Test3 = new CWJadenCased();
            string input = "Jaden Was Here";
            string expected = "Jaden Was Here";

            //Act
            string result = Test3.ToJadenCase(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should return the same string but with the first letter of each word capitalized. If they are already capitalized, then the word should remain unchanged");

        }
    }
}

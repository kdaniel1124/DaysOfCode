using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day34Tests
    {
        [TestMethod]
        public void DaysOfCode34_HelloName_LowerCaseDaniel()
        {
            //Arrange
            DaysOfCode34 Test1 = new DaysOfCode34();
            string input = "daniel";
            string expected = "Hello Daniel!";

            //Act
            string result = Test1.HelloName(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should capitalize the first letter of user's name and return it in the format of 'Hello {name}!'");
        }
             [TestMethod]
        public void DaysOfCode34_HelloName_EmptyString()
        {
            //Arrange
            DaysOfCode34 Test2 = new DaysOfCode34();
            string input = "";
            string expected = "Come on give me a longer name than that!";

            //Act
            string result = Test2.HelloName(input);

            //Assert
            Assert.AreEqual(expected, result, "If provided an empty string the method should return a message asking for the user's name");
        }
             [TestMethod]
        public void DaysOfCode34_HelloName_AllCaps()
        {
            //Arrange
            DaysOfCode34 Test3 = new DaysOfCode34();
            string input = "Goodbye";
            string expected = "Hello Goodbye!";

            //Act
            string result = Test3.HelloName(input);

            //Assert
            Assert.AreEqual(expected, result, "Method should capitalize the first letter of user's name and return it, if the name is already capitalized it should be unchanged.");
        }

    }
}

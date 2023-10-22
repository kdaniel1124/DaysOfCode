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
    }
}

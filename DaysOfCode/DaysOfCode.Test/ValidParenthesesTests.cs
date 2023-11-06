using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void ValidParenthesesKata_ValidParentheses_CloseAtStart()
        {
            //Arrange
            ValidParenthesesKata Test1 = new ValidParenthesesKata();
            string input = ")(())(";
            bool expected = false;

            //Act
            bool result = Test1.ValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, result, "At no point should there be more close parentheses than open");
        }

    }
}

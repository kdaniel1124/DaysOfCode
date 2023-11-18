using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day52Tests
    {
        [TestMethod]
        public void DaysOfCode52_MakeOutWord_LongOuter()
        {
            //Arrange
            DaysOfCode52 test1 = new DaysOfCode52();
            string innerInput = "Bam!";
            string outerInput = "(((((((((())))))))))";
            string expected = "((Bam!))";

            //Act
            string result = test1.MakeOutWord(outerInput, innerInput);

            //Assert
            Assert.AreEqual(expected, result, "Method should add two characters from each side of the outer string, with the complete inner string in the middle.");
        }

        [TestMethod]
        public void DaysOfCode52_MakeOutWord_NoOuter()
        {
            //Arrange
            DaysOfCode52 test2 = new DaysOfCode52();
            string innerInput = "Final";
            string outerInput = "";
            string expected = "Final";

            //Act
            string result = test2.MakeOutWord(outerInput, innerInput);

            //Assert
            Assert.AreEqual(expected, result, "If outer string is empty then method should simply return the inner string");
        }

        [TestMethod]
        public void DaysOfCode52_MakeOutWord_()
        {
            //Arrange
            DaysOfCode52 test3 = new DaysOfCode52();
            string innerInput = "";
            string outerInput = "[]";
            string expected = "[[]]";

            //Act
            string result = test3.MakeOutWord(outerInput, innerInput);

            //Assert
            Assert.AreEqual(expected, result, "Method should add two characters from each side of the outer string. If the inner string is empty then the method should simply return four characters from the outer string.");
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day33Tests
    {
        [TestMethod]
        public void DaysOfCode33_ComboString_EmptyA()
        {
            //Arrange
            DaysOfCode33 Test1 = new DaysOfCode33();
            string inputA = "";
            string inputB = "Camp";
            string expected = "Camp";

            //Act
            string result = Test1.ComboString(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should determine which string is shorter, then return the strings combined in this order: 'shorter + longer + shorter");
        }

        [TestMethod]
        public void DaysOfCode33_ComboString_SameLength()
        {
            //Arrange
            DaysOfCode33 Test2 = new DaysOfCode33();
            string inputA = "Bake";
            string inputB = "Take";
            string expected = "Invalid input, cannot compute. Must enter two strings of different length.";

            //Act
            string result = Test2.ComboString(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should determine which string is shorter, if they are same length then return a message asking for two strings of different lengths");
        }

        [TestMethod]
        public void DaysOfCode33_ComboString_LongA()
        {
            //Arrange
            DaysOfCode33 Test3 = new DaysOfCode33();
            string inputA = "Banana";
            string inputB = "Cake";
            string expected = "CakeBananaCake";

            //Act
            string result = Test3.ComboString(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Method should determine which string is shorter, then return the strings combined in this order: 'shorter + longer + shorter");
        }

    }
}

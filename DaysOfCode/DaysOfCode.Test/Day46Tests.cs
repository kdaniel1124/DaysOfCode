using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day46Tests
    {
        [TestMethod]
        public void DaysOfCode46_List2Array_OneTwoThree()
        {
            //Arrange
            DaysOfCode46 Test1 = new DaysOfCode46();
            List<string> input = new List<string> {"one", "two", "three"};
            string[] expected = new string[] {"one", "two", "three"};

            //Act
            string[] result = Test1.List2Array(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Should return the original elements in the original order in an array");
        }

        [TestMethod]
        public void DaysOfCode46_List2Array_EmptyList()
        {
            //Arrange
            DaysOfCode46 Test2 = new DaysOfCode46();
            List<string> input = new List<string> {};
            string[] expected = new string[] {};

            //Act
            string[] result = Test2.List2Array(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "If list is empty method should return empty array");
        }

        [TestMethod]
        public void DaysOfCode46_List2Array_OneEmptyString()
        {
            //Arrange
            DaysOfCode46 Test3 = new DaysOfCode46();
            List<string> input = new List<string> {""};
            string[] expected = new string[] {""};

            //Act
            string[] result = Test3.List2Array(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Should return the original element in an array regardless of string length");
        }

    }
}

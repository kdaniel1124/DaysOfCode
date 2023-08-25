using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day43Tests
    {
        [TestMethod]
        public void DaysOfCode43_ReverseList_ListLengthOne()
        {
            //Arrange
            DaysOfCode43 Test1 = new DaysOfCode43();

            List<string> input = new List<string> { "One" };

            List<string> expected = new List<string> { "One" };

            //Act
            List<string> result = Test1.ReverseList(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "A list of length one should return unaltered");
        }

        [TestMethod]
        public void DaysOfCode43_ReverseList_OneThroughFourReversed()
        {
            //Arrange
            DaysOfCode43 Test2 = new DaysOfCode43();

            List<string> input = new List<string> { "One", "Two", "Three", "Four" };

            List<string> expected = new List<string> { "Four", "Three", "Two", "One"};

            //Act
            List<string> result = Test2.ReverseList(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should a version of the original list but reversed");
        }
        [TestMethod]
        public void DaysOfCode43_ReverseList_EmptyList()
        {
            //Arrange
            DaysOfCode43 Test3 = new DaysOfCode43();

            List<string> input = new List<string> {};

            List<string> expected = new List<string> {};

            //Act
            List<string> result = Test3.ReverseList(input);

            //Assert
            CollectionAssert.AreEqual(expected, result, "An empty list should simply return an empty list");
        }

    }
}

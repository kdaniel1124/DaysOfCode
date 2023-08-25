using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day47Tests
    {
        [TestMethod]
        public void DaysOfCode47_FoundItTwice_FourOnesShouldReturnTrue()
        {
            //Arrange
            DaysOfCode47 Test1 = new DaysOfCode47();
            List<int> nums = new List<int> {1, 2, 1, 3, 1, 4, 1, 24};

            //Act
            bool result = Test1.FoundItTwice(nums, 1);

            //Assert
            Assert.AreEqual(true, result, "Method should return true with four of the same value");
        }

        [TestMethod]
        public void DaysOfCode47_FoundItTwice_NoDuplicates()
        {
            //Arrange
            DaysOfCode47 Test2 = new DaysOfCode47();
            List<int> nums = new List<int> {1, 2, 3, 4, 5, 6, 24};

            //Act
            bool result = Test2.FoundItTwice(nums, 4);

            //Assert
            Assert.AreEqual(false, result, "Method should return false when no multiples are present in list");
        }

        [TestMethod]
        public void DaysOfCode47_FoundItTwice_EmptyListTest()
        {
            //Arrange
            DaysOfCode47 Test3 = new DaysOfCode47();
            List<int> nums = new List<int> {};

            //Act
            bool result = Test3.FoundItTwice(nums, 42);

            //Assert
            Assert.AreEqual(false, result, "Method should return false when provided an empty list regardless of given value");
        }

    }
}

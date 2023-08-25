using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day48Tests
    {
        [TestMethod]
        public void DaysOfCode_FindLargest_HighestAtStart()
        {
            //Arrange
            DaysOfCode48 Test1 = new DaysOfCode48();
            List<int> input = new List<int> { 9001, 9000, 10, 8000 };

            //Act
            int result = Test1.FindLargest(input);

            //Assert
            Assert.AreEqual(9001, result, "Method should return highest number regardless of where it occurs in the list");
        }

        [TestMethod]
        public void DaysOfCode_FindLargest_ListOfOnlyOne()
        {
            //Arrange
            DaysOfCode48 Test2 = new DaysOfCode48();
            List<int> input = new List<int> { 1 };

            //Act
            int result = Test2.FindLargest(input);

            //Assert
            Assert.AreEqual(1, result, "Method should return highest number regardless of where it occurs in the list");
        }

        [TestMethod]
        public void DaysOfCode_FindLargest_NegativeNumber()
        {
            //Arrange
            DaysOfCode48 Test3 = new DaysOfCode48();
            List<int> input = new List<int> { -9001, -9000, -10, -8000 };

            //Act
            int result = Test3.FindLargest(input);

            //Assert
            Assert.AreEqual(-10, result, "Method should return highest number regardless of where it occurs in the list");
        }

    }
}

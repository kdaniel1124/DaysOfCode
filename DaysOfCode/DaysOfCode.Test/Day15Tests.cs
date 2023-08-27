using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day15Tests
    {
        [TestMethod]
        public void DaysOfCode15_Has23_Pure23Test()
        {
            //Arrange
            DaysOfCode15 Test1 = new DaysOfCode15();
            int[] input = new int[] { 23, 23};

            //Act
            bool result = Test1.Has23(input);

            //Assert
            Assert.AreEqual(false, result, "method should (ironically) return false when given 23's because we are only for looking for 2's OR 3's");
        }

        [TestMethod]
        public void DaysOfCode15_Has23_Both3And2()
        {
            //Arrange
            DaysOfCode15 Test2 = new DaysOfCode15();
            int[] input = new int[] { 3, 2};

            //Act
            bool result = Test2.Has23(input);

            //Assert
            Assert.AreEqual(true, result, "method should return true if 3 and/or 2 are present in the array");
        }

        [TestMethod]
        public void DaysOfCode15_Has23_No2Or3()
        {
            //Arrange
            DaysOfCode15 Test3 = new DaysOfCode15();
            int[] input = new int[] { 0, 146};

            //Act
            bool result = Test3.Has23(input);

            //Assert
            Assert.AreEqual(false, result, "method should return false if no 2's or 3's are present");
        }

    }
}

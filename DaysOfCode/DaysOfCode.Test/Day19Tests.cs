using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day19Tests
    {
        [TestMethod]
        public void DaysOfCode19_Double23_ArrayLengthZero()
        {
            //Arrange
            DaysOfCode19 Test1 = new DaysOfCode19();
            int[] input = new int[] { };

            //Act
            bool result = Test1.Double23(input);

            //Assert
            Assert.AreEqual(false, result, "If array is not exactly length of 2 then method should return false");
        }

        [TestMethod]
        public void DaysOfCode19_Double23_Two2sTest()
        {
            //Arrange
            DaysOfCode19 Test2 = new DaysOfCode19();
            int[] input = new int[] { 2, 2 };

            //Act
            bool result = Test2.Double23(input);

            //Assert
            Assert.AreEqual(true, result, "If nums is made up of exactly and exclusively two 2's then method should return true");
        }

        [TestMethod]
        public void DaysOfCode19_Double23_Two3sTest()
        {
            //Arrange
            DaysOfCode19 Test3 = new DaysOfCode19();
            int[] input = new int[] { 3, 3 };

            //Act
            bool result = Test3.Double23(input);

            //Assert
            Assert.AreEqual(true, result, "If nums is made up of exactly and exclusively two 3's then method should return true");
        }

    }
}

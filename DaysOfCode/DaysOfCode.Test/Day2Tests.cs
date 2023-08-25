using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
   
    public class Day2Tests
    {
        [TestMethod]
        public void DaysOfCode2_Has12_ShouldHandleNegatives()
        {
            //Arrange
            DaysOfCode2 Test1 = new DaysOfCode2();
            int[] input = { 2, 3, -1, -2, -1 };

            //Act
            bool result = Test1.Has12(input);

            //Assert
            Assert.AreEqual(false, result, "Has12 should only get positive 1's and 2's");
        }

        [TestMethod]
        public void DaysOfCode2_Has12_ShouldNotTriggerOnActualTwelves()
        {
            //Arrange
            DaysOfCode2 Test2 = new DaysOfCode2();
            int[] input = { 6, 1, 12, 3, 1 };

            //Act
            bool result = Test2.Has12(input);

            //Assert
            Assert.AreEqual(false, result, "Has12 should not count actual twelves, only individual ones proceeded by twos.");
        }

        [TestMethod]
        public void DaysOfCode2_Has12_ShouldHandleMultipleTriggers()
        {
            //Arrange
            DaysOfCode2 Test3 = new DaysOfCode2();
            int[] input = {1, 2, 1, 2, 1};

            //Act
            bool result = Test3.Has12(input);

            //Assert
            Assert.AreEqual(true, result, "Method should work even with multiple instances of 1, 2");
        }
    }
}

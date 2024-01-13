using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day35Tests
    {
        [TestMethod]
        public void DaysOfCode35_HasBad_MiddleBad()
        {
            //Arrange
            DaysOfCode35 Test1 = new DaysOfCode35();
            string input = "xbadx";

            //Act
            bool result = Test1.HasBad(input);

            //Assert
            Assert.AreEqual(true, result, "If the string contains the word 'bad' within the first five chars of the string then we should return true.");
        }

        [TestMethod]
        public void DaysOfCode35_HasBad_JustBad()
        {
            //Arrange
            DaysOfCode35 Test2 = new DaysOfCode35();
            string input = "bad";

            //Act
            bool result = Test2.HasBad(input);

            //Assert
            Assert.AreEqual(true, result, "If the string contains the word 'bad' within the first five chars of the string then we should return true.");
        }

        [TestMethod]
        public void DaysOfCode35_HasBad_NoBad()
        {
            //Arrange
            DaysOfCode35 Test3 = new DaysOfCode35();
            string input = "xdabx";

            //Act
            bool result = Test3.HasBad(input);

            //Assert
            Assert.AreEqual(false, result, "If the string contains the word 'bad' within the first five chars of the string then we should return true.");
        }

    }
}

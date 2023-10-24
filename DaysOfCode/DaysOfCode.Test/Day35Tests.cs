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
        public void DaysOfCode35_HasBad_()
        {
            //Arrange
            DaysOfCode35 Test1 = new DaysOfCode35();
            string input = "xbadx";

            //Act
            bool result = Test1.HasBad(input);

            //Assert
            Assert.AreEqual(true, result, "If the string contains the word 'bad' within the first five chars of the string then we should return true.");

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void DaysOfCode7_NoTriples_ArrayLengthLessThanThree()
        {
            //Arrange
            DaysOfCode7 Test1 = new DaysOfCode7();
            int[] input = { 1, 2 };

            //Act
            bool result = Test1.NoTriples(input);

            //Assert
            Assert.AreEqual(true, result, "If an array is less than two numbers long it must return false");
        }

        [TestMethod]
        public void DaysOfCode7_NoTriples_TrueInBeginning()
        {
            //Arrange
            DaysOfCode7 Test2 = new DaysOfCode7();
            int[] input = {6, 6, 6, 2, 4, 1};

            //Act
            bool result = Test2.NoTriples(input);

            //Assert
            Assert.AreEqual(false, result, "If three in a row NoTriples should return false");
        }
    }
}

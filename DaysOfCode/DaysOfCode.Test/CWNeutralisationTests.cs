using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class CWNeutralisationTests
    {
        [TestMethod]
        public void CWNeautralisation_Neutralisation_AllMatches()
        {
            //Arrange
            CWNeutralisation Test1 = new CWNeutralisation();
            string inputA = "-+-+-";
            string inputB = "-+-+-";
            string expected = "-+-+-";

            //Act
            string result = Test1.Neutralisation(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Any time a symbol matches, the method should simply add that symbol to the return string");
        }

        [TestMethod]
        public void CWNeautralisation_Neutralisation_LongMixedString()
        {
            //Arrange
            CWNeutralisation Test2 = new CWNeutralisation();
            string inputA = "----++++";
            string inputB = "-+-+-+-+";
            string expected = "-0-00+0+";

            //Act
            string result = Test2.Neutralisation(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Any time a symbol matches, the method should add that symbol to the return string. Otherwise the method should add a '0'");
        }

        [TestMethod]
        public void CWNeautralisation_Neutralisation_NoMatches()
        {
            //Arrange
            CWNeutralisation Test3 = new CWNeutralisation();
            string inputA = "-+-+-";
            string inputB = "+-+-+";
            string expected = "00000";

            //Act
            string result = Test3.Neutralisation(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Any time a symbol between the two input strings doesn't match, the method should add a'0' to the return string");
        }

    }
}

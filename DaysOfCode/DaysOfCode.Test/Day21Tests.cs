using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day21Tests
    {
        [TestMethod]
        public void DaysOfCode21_Blackjack_DoubleBust()
        {
            //Arrange
            DaysOfCode21 Test1 = new DaysOfCode21();
            int inputA = 22;
            int inputB = 24;
            int expected = 0;

            //Act
            int result = Test1.Blackjack(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Given two ints, if they are both over 21 then method should simply return 0.");
        }

        [TestMethod]
        public void DaysOfCode21_Blackjack_OneBust()
        {
            //Arrange
            DaysOfCode21 Test2 = new DaysOfCode21();
            int inputA = 6;
            int inputB = 24;
            int expected = 6;

            //Act
            int result = Test2.Blackjack(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Given two ints the method should return whichever one is bigger while not going over 21.");
        }

        [TestMethod]
        public void DaysOfCode21_Blackjack_NoBustTie()
        {
            //Arrange
            DaysOfCode21 Test1 = new DaysOfCode21();
            int inputA = 17;
            int inputB = 17;
            int expected = 17;

            //Act
            int result = Test1.Blackjack(inputA, inputB);

            //Assert
            Assert.AreEqual(expected, result, "Given two ints the method should return whichever one is bigger while not going over 21.");
        }

    }
}

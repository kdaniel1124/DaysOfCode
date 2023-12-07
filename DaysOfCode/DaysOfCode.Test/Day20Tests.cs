using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day20Tests
    {
        [TestMethod]
        public void DaysOfCode20_BiggerTwo_FirstBigger()
        {
            //Arrange
            DaysOfCode20 Test1 = new DaysOfCode20();
            int[] inputA = { 9, 8 };
            int[] inputB = { 10, 1 };
            int[] expected = inputA;

            //Act
            int[] result = Test1.BiggerTwo(inputA, inputB);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should compare the sums of each array and return whichever is bigger, or the first one in the event of a tie.");
        }

        [TestMethod]
        public void DaysOfCode20_BiggerTwo_Negatives()
        {
            //Arrange
            DaysOfCode20 Test2 = new DaysOfCode20();
            int[] inputA = { -9, -8 };
            int[] inputB = { -10, -1 };
            int[] expected = inputB;

            //Act
            int[] result = Test2.BiggerTwo(inputA, inputB);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should compare the sums of each array and return whichever is bigger, or the first one in the event of a tie.");

        }

        [TestMethod]
        public void DaysOfCode20_BiggerTwo_Tie()
        {
            //Arrange
            DaysOfCode20 Test1 = new DaysOfCode20();
            int[] inputA = { 9, 1 };
            int[] inputB = { 5, 5 };
            int[] expected = inputA;

            //Act
            int[] result = Test1.BiggerTwo(inputA, inputB);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should compare the sums of each array and return whichever is bigger, or the first one in the event of a tie.");


        }

    }
}

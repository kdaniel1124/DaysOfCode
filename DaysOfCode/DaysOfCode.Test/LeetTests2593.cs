using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class LeetTests2593
    {
        [TestMethod]
        public void LeetProblem2593_FindScore_LengthOfSixTest()
        {
            //Arrange
            LeetProblem2593 Test1 = new LeetProblem2593();
            int[] input = new int[] { 2, 1, 3, 4, 5, 2 };
            long expected = 7;

            //Act
            long result = Test1.FindScore(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
        /*[TestMethod]
        public void LeetProblem2593_FindScore_ProblemArray()
        {
            //Arrange
            LeetProblem2593 Test2 = new LeetProblem2593();
            int[] input = new int[] { 10, 44, 10, 8, 48, 30, 17, 38, 41, 27, 16, 33, 45, 45, 34, 30, 22, 3, 42, 42 };
            long expected = 212;

            //Act
            long result = Test2.FindScore(input);

            //Assert
            Assert.AreEqual(expected, result);
        }*/

    }
}

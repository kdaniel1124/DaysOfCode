using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    [TestClass]
    public class Day28Tests
    {
        [TestMethod]
        public void DaysOfCode28_FizzBuzz_BuzzToFifteen()
        {
            //Arrange
            DaysOfCode28 Test1 = new DaysOfCode28();
            string[] expected = new string[] { "1, ", "2, ", "Fizz, ", "4, ", "Buzz, ", "Fizz, ", "7, ", "8, ", "Fizz, ", "Buzz, ", "11, ", "Fizz, ", "13, ", "14, ", "FizzBuzz, " };

            //Act
            string[] result = Test1.FizzBuzz(15);

            //Assert
            CollectionAssert.AreEqual(expected, result, "Method should create an array of length 'num' and populate it with either 'Fizz' 'Buzz' 'FizzBuzz' or a number in ascending order");
        }

    }
}

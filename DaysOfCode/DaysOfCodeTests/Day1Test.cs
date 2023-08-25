using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DaysOfCode.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        public void DaysOfCode1_SwapEnds_SwapsEndsOnThreeLengthArray()
        {
            try
            {
                //Arrange
                DaysOfCode1 Test1 = new DaysOfCode1();

                int[] input = { 1, 2, 3 };
                int[] expected = {3, 2, 1};

                //Act
                int[] result = Test1.SwapEnds(input);

                //Assert
                CollectionAssert.AreEqual(expected, result, "Woops, try again!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        [TestMethod]
        public void DaysOfCode1_SwapEnds_ArrayLengthOne()
        {
            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

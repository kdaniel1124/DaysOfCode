using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaysOfCode1;


namespace DaysOfCode1.Tests
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
                //Arrange
                DaysOfCode1 Test2 = new DaysOfCode1();
                int[] input = { 6 };
                int[] expected = { 6 };

                //Act
                int[] result = Test2.SwapEnds(input);

                //Assert
                CollectionAssert.AreEqual(expected, result, "Array of length 1 should return unchanged");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        [TestMethod]
        public void DaysOfCode1_SwapEnds_ShouldHandleNegatives()
        {
            try
            {
                //Arrange
                DaysOfCode1 Test3 = new DaysOfCode1();
                int[] input = { 5, -5 };
                int[] expected = { -5, 5 };

                //Act
                int[] result = Test3.SwapEnds(input);

                //Assert
                CollectionAssert.AreEqual(expected, result, "SwapEnds should switch the first and last indexes regardless of negativity");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

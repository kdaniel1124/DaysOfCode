using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DaysOfCode1
{
    public class DaysOfCode1
    {
        public int[] SwapEnds(int[] nums)
        {
            int[] result = nums; //creates a copy of nums for us to swap end of and then return
            result[0] = nums[nums.Length - 1]; //sets the first position of result to the last number in nums
            result[nums.Length - 1] = nums[0]; //sets the last position in result to the first position in nums

            return result;
        }




    }
}

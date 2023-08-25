using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode11
    {
        public int[] MakeMiddle(int[] nums)
        {
            int[] middleTwo = new int[] 
            { 
                nums[(nums.Length / 2) - 1], 
                nums[nums.Length / 2] 
            };

            return middleTwo;
        }
    }
}

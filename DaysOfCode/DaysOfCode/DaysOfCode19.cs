using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode19
    {
        public bool Double23(int[] nums)
        {
            if (nums.Length != 2)
            {
                // If the array is not Length 2 then it cannot contain exactly two 2's or 3's, meaning it would always be false
                return false;
            }
            else
            {
                // Tests if the array contains exactly two 2's OR exactly two 3's, then the method should return true or false accordingly
                return ((nums[0] == 2 && nums[1] == 2) || (nums[0] == 3 && nums[1] == 3));
            }
        }
    }
}

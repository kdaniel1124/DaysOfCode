using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode25
    {
        public bool IsStrictlyIncreasing(int[] nums)
        {
            if (nums.Length < 2)
            {
                return false;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode17
    {
        public int[] Fix23(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == 3 && nums[i - 1] == 2)
                {
                    nums[i] = 0;
                }
            }
            return nums;
        }
    }
}

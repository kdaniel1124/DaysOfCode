using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode15
    {
        public bool Has23(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2 || nums[i] == 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

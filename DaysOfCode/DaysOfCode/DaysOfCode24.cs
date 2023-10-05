using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode24
    {
        public bool Array123(int[] nums)
        {
            if(nums.Length >= 3)
            {
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i] == 3 && nums[i - 1] == 2 && nums[i - 2] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

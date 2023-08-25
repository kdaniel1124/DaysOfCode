using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode13
    {
        public int[] MakeEnds(int[] nums)
        {
            int[] result = new int[] { nums[0], nums[nums.Length-1] };

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode48
    {
        public int FindLargest(List<int> nums)
        {
            int highest = nums[0];
            foreach(int num in nums)
            {
                if (num > highest)
                {
                    highest = num;
                }
            }
            return highest;
        }
    }
}

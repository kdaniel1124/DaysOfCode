using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode12
    {
        public int[] MakeLast(int[] nums)
        {
            int[] doubledArray = new int[nums.Length * 2];

            doubledArray[doubledArray.Length - 1] = nums[nums.Length - 1];

            return doubledArray;
        }
    }
}

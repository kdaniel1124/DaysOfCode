using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode23
    {
        public int NumCount(int num, int[] nums)
        {
            int result = 0;

            foreach (int n in nums)
            {
                if (n == num)
                {
                    result++;
                }
            }

            return result;
        }
    }
}

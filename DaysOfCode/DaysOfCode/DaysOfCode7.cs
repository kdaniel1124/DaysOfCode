using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode7
    {
        public bool NoTriples(int[] nums)
        {
            if (nums.Length >= 3) // Noice.
            {
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i - 2] == nums[i - 1] && nums[i - 1] == nums[i])
                    {
                        return false;
                    }
                }
                Console.WriteLine("baba");
            }
            return true;
        }
    }
}

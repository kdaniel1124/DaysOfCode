using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode2
    {
        public bool Has12(int[] nums)
        {
            bool has1 = false;
            foreach (int num in nums)
            {
                if(num == 1) //Checks each number to see if we have a 1, if so it saves/remembers
                {
                    has1 = true;
                }
                if(num == 2 && has1) //Then checks if each number is a 2, if it is we will then check if we have already had a 1
                {
                    return true;
                }
            }
            return false;
        }
    }
}

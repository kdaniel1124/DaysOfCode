using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode47
    {
        public bool FoundItTwice(List<int> nums, int value)
        {
            int valueCount = 0;

            foreach(int number in nums)
            {
                if(number == value)
                {
                    valueCount++;
                }
                if(valueCount > 1)
                {
                    //return true;
                }
            }
            //return false;

            return (valueCount >= 2);
        }
    }
}

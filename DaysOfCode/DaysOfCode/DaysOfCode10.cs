using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode10
    {
        public bool More14(int[] nums)
        {
            int oneCount = 0;
            int fourCount = 0;

            foreach(int num in nums)
            {
                if(num == 1)
                {
                    oneCount++;
                }
                if(num == 4)
                {
                    fourCount++;
                }
            }
            return (oneCount > fourCount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode16
    {
        public int[] FizzArray(int num)
        {
            if(num < 1)
            {
                int[] result = new int[0];

                return result;
            }
            else
            {
                int[] result = new int[num];

                for(int i = 0; i < num; i++)
                {
                    result[i] = i;
                }

                return result;
            }
        }
    }
}

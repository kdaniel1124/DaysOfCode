using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode41
    {
        public int CountXX(string str)
        {
            int xxCount = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' && str[i + 1] == 'x')
                {
                    xxCount++;
                }
            }
            return xxCount;
        }
    }
}

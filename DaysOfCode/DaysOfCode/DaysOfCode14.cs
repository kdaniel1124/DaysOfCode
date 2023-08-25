using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode14
    {
        public bool LessBy10(int a, int b, int c)
        {
            int highest = 0;
            if(a >= b && a >= c)
            {
                highest = a;
            }
            else if (b >= a && b >= c)
            {
                highest = b;
            }
            else
            {
                highest = c;
            }

            int lowest = 0;
            if (a <= b && a <= c)
            {
                lowest = a;
            }
            else if (b <= a && b <= c)
            {
                lowest = b;
            }
            else
            {
                lowest = c;
            }

            if ((highest - lowest) >= 10)
            {
                return true;
            }
            else return false;



        }
    }
}

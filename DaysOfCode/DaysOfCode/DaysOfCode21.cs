using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode21
    {
        public int Blackjack(int a, int b)
        {
            if(a >= b && a <= 21)
            {
                return a;
            }
            else if (b > a && b <= 21)
            {
                return b;
            }
            else
            {
                return 0;
            }
        }
    }
}

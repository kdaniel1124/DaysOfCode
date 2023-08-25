using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode3
    {
        public int GreenTicket(int a, int b, int c)
        {
            if (a == b && b == c) //If all three numbers are the same then you win 20
            {
                return 20;
            }
            if (a != b && b != c && a != c) //If none of your numbers are the same you win 0 dollars
            {
                return 0;
            }
            else //If we have made it to this point without hitting a return then we know the only option left is that two of the numbers match
            {
                return 10;
            }
        }
    }
}

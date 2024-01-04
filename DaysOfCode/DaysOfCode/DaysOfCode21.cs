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
            /*if(a >= b && a <= 21)
            {
                return a;
            }
            else if (b > 21 && a > 21)
            {
                return 0;
            }
            else
            {
                return b;
            }*/

            int[] hands = { a, b };

            for (int i = 0; i < hands.Length; i++)
            {
                if (hands[i] > 21)
                {
                    hands[i] = 0;
                }
            }

            return hands.Max();
        }
    }
}

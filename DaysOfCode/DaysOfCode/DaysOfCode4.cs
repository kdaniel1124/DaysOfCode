using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode4
    {
        public int Start1(int[] a, int[] b)
        {
            int result = 0;

            if (a[0] == 1 && b[0] == 1)
            {
                return 2;
            }
            else if (a[0] != 1 && b[0] != 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

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

            if(a.Length > 0 && a[0] == 1)
            {
                result++;
            }

            if(b.Length > 0 && b[0] == 1)
            {
                result++;
            }

            return result;
        }
    }
}

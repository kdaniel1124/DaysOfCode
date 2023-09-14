using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode18
    {
        public bool EvenlySpaced(int a, int b, int c)
        {
            List<int> orderedInts = new List<int> { a, b, c };
            orderedInts.Sort();

            return ((orderedInts[0] - orderedInts[1]) == (orderedInts[1] - orderedInts[2]));
        }
    }
}

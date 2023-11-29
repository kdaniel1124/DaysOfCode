using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode6
    {
        public bool Only14(int[] arr)
        {
            foreach (int num in arr)
            {
                if( num != 1 && num != 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

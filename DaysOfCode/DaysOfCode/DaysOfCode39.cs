using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode39
    {
        public string ExtraEnd(string str)
        {
            string last = "";
            if (str.Length > 1)
            {
                last = str.Substring(str.Length - 2);
            }
            else if (str.Length == 1)
            {
                last = str.Substring(str.Length - 1);
            }

            return (last + last + last);
        }
    }
}

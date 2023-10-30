using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode38
    {
        public string FirstHalf(string str)
        {
            //Given a string of even length, return the first half of the string
            return (str.Substring(0, str.Length / 2));
        }
    }
}

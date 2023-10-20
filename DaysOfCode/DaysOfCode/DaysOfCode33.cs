using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode33
    {
        public string ComboString(string a, string b)
        {
            //Find out which string is longer (they will never be the same length, although one may be empty)
            //Whichever string is shorter will be the bread in the string sandwich, while the longer string will be the meat
            //ie: a='for' b='banana' then the method should return 'forbananafor'

            string result = "";

            if(a.Length > b.Length)
            {
                result = b + a + b;
            }
            else if(a.Length < b.Length)
            {
                result = a + b + a;
            }
            else
            {
                result = "Invalid input, cannot compute. Must enter two strings of different length.";
            }
            return result;
        }
    }
}

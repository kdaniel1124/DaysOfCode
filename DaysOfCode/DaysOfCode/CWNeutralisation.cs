using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class CWNeutralisation
    {

        /*
            ("+-+", "+--") ➞ "+-0"
            Compare the first characters of each string, then the next in turn.
            "+" against a "+" returns another "+".
            "-" against a "-" returns another "-".
            "+" against a "-" returns "0".
            Return the string of characters.
        */
        public string Neutralisation(string a, string b)
        {
            string result = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    result += a[i];
                }
                else
                {
                    result += "0";
                }
            }
            return result;
        }
    }
}

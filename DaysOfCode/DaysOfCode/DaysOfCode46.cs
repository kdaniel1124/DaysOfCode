using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode46
    {
        public string[] List2Array(List<string> input)
        {
            string[] output = new string[input.Count];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = input[i];
            }

            return output;
        }
    }
}

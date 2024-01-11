using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode28
    {
        public string[] FizzBuzz(int num)
        {
            string[] result = new string[num];

            for(int i = 1; i <= num; i++)
            {
                if ((i % 15) == 0)
                {
                    result[i - 1] = "FizzBuzz, ";
                }
                else if(i % 5 == 0)
                {
                    result[i - 1] = "Buzz, ";
                }
                else if(i % 3 == 0)
                {
                    result[i - 1] = "Fizz, ";
                }
                else
                {
                    result[i - 1] = $"{i}, "; 
                }
            }
            string last = result[result.Length - 1];
            last = last.Substring(0, last.Length - 2);
            result[result.Length - 1] = last;

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode36
    {
        public string FrontTimes(string str, int num)
        {
            string result = "";
            string front = "";
            if (str.Length >= 3)
            {
                front = str.Substring(03);
            }
            else if (str.Length == 2)
            {
                front = str.Substring(0, 2);
            }
            else if (str.Length == 1)
            {
                front = str.Substring(0, 1);
            }

            for (int i = 0; i < num; i++)
            {
                result += front;
            }

            return result;
        }
    }
}

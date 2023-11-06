using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class ValidParenthesesKata
    {
        public bool ValidParentheses(string str)
        {
            int open = 0;
            int close = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '(')
                {
                    open++;
                }
                if (str[i] == ')')
                {
                    close++;
                }
                if (close > open)
                {
                    return false;
                }
            }
            return (open == close);
        }
    }
}
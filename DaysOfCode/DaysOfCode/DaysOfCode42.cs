using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode42
    {
        public bool DoubleX(string str)
        {
            bool result = false;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.ToLower(str[i]) == 'x')
                {
                    if (char.ToLower(str[i + 1]) == 'x')
                    {
                        result = true;
                    }

                    break;
                }
            }
            return result;
        }
    }
}

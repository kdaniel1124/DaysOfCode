﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode.Test
{
    public class DaysOfCode32
    {
        public int Factorial(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else
            {

                int result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
    }
}

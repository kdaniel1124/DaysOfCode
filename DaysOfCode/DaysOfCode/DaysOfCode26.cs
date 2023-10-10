using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode26
    {
        //Prompt: 'Create an integer method that takes in no arguments or parameters. Return the sum of the odd integers between 1 and 100 inclusive.'
        public int SumOdds()
        {
            int total = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    total += i;
                }
            }
            return total;
        }

        // I created an overload method where you can enter the number you'd like the method to count up to
        public int SumOdds(int endWith)
        {
            int total = 0;

            for (int i = 1; i <= endWith; i++)
            {
                if (i % 2 == 1)
                {
                    total += i;
                }
            }
            return total;
        }

        // I created another method that allows you to also indicate which number you'd like the method to begin on
        public int SumOdds(int startWith, int endWith)
        {
            int total = 0;

            for (int i = startWith; i <= endWith; i++)
            {
                if (i % 2 == 1)
                {
                    total += i;
                }
            }
            return total;
        }

    }
}

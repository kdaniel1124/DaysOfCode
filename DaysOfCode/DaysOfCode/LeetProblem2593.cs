using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class LeetProblem2593
    {
        public long FindScore(int[] nums)
        {
            int score = 0;
            int lowest;
            int index;
            List<int> numbers = nums.ToList();
            while(numbers.Count > 0)
            {
                lowest = numbers.Min();
                score += lowest;
                index = numbers.IndexOf(lowest);
                if (index == 0 && index == numbers.Count - 1)
                {
                    numbers.Remove(lowest);
                }
                else if (index == 0)
                {
                    numbers.RemoveRange(index, 2);
                }
                else if(index == numbers.Count - 1)
                {
                    numbers.RemoveRange(index - 1, 2);
                }
                else
                {
                    numbers.RemoveRange(index - 1, 3);
                }
            }
            return score;
        }
    }
}

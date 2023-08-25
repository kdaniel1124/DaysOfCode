using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode43
    {
        public List<string> ReverseList(List<string> strings)
        {
            List<string> result = new List<string>();

            for (int i = strings.Count - 1; i >= 0; i--)
            {
                result.Add(strings[i]);
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode34
    {
        public string HelloName(string name)
        {
            if (name.Length < 1)
            {
                return "Come on give me a longer name than that!";
            }
            else
            {
                string upperName = name[0].ToString().ToUpper() + name.Substring(1);

                return ($"Hello {upperName}!");
            }
        }
    }
}

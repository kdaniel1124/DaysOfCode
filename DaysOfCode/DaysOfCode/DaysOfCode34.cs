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
            string upperName = name[0].ToString().ToUpper() + name.Substring(1);
            name[0].ToString().ToUpper();

            return ($"Hello {upperName}!");
        }
    }
}

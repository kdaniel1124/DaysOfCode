using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class DaysOfCode52
    {
        public string MakeOutWord(string outWord, string inWord)
        {
            if(outWord.Length < 1)
            {
                return inWord;
            }
            else
            {
                char outLeft = outWord[0];
                char outRight = outWord[outWord.Length - 1];

                return (outLeft + outLeft + inWord + outRight + outRight);
            }
        }
    }
}

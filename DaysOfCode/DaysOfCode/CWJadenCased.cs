using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class CWJadenCased
    {
        public string ToJadenCase(string phrase)
        {
            string[] jadeBank = phrase.Split(" ");
            string result = "";
            if (phrase.Length > 0)
            {
                foreach (string word in jadeBank)
                {
                    result += (char.ToUpper(word[0]) + word.Substring(1) + " ");
                }
            }

            return result.Trim();
            /*string result = "";

            if (phrase.Length > 0)
            {
                result += phrase[0].ToString().ToUpper();

                for (int i = 1; i < phrase.Length; i++)
                {
                    if (phrase[i - 1].ToString() == " ")
                    {
                        result += phrase[i].ToString().ToUpper();
                    }
                    else
                    {
                        result += phrase[i];
                    }
                }
            }

            return result;*/
        }
    }
}

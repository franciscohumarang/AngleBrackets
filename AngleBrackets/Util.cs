using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleBrackets
{

    public class Util
    {
        public static bool MatchingTest(string inputStr)
        {
            int openBracketCount = 0;

            foreach (char c in inputStr)
            {
                if (c == '<')
                {
                    openBracketCount++;
                }
                else if (c == '>')
                {
                    openBracketCount--;
                    if (openBracketCount < 0)
                    {
                        return false;
                    }
                }
            }

            return openBracketCount == 0;
        }
    }
}

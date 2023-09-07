using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleBrackets
{
    /************************
     * 
     *  This method hecks if a string has matching 
     *  angle brackets
     */
    public class Util
    {
        public static bool MatchingTest(string input)
        {
            int rightAngleBracketCtr = 0; // Initialize a count for right angle brackets.

            foreach (char c in input)
            {
                if (c == '<')
                {
                    rightAngleBracketCtr++;
                }
                else if (c == '>')
                {
                    // If the count goes negative, it means a left angle bracket appeared without a corresponding right or open bracket.
                    // In this case, return false immediately.
                    rightAngleBracketCtr--;
                    if (rightAngleBracketCtr < 0)
                    {
                        return false;
                    }
                }
            }

            //if the count is zero, it means all brackets are matched.
            bool rValue = rightAngleBracketCtr == 0 ? true : false;
            
            return rValue; 
        }
    }
}

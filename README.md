# AngleBrackets
Open and close angle bracket test

A method that takes a string argument and returns whether or not characters in the
string have matching angle brackets. Meaning for every < there is a corresponding >
bracket. Return true if they do, return false if they do not.
Please unit test with the following use cases (and any others you choose to ensure
functionality):
Test string - Expected result
```
<> - True
>< - False (closed bracket can’t proceed all open brackets.)
<<> - False (one bracket pair was not closed)
“” - True. (no brackets in the string will return True)
<abc...xyz> - True (non-bracket characters are ignored appropriately)
```
## Code Description:
The actual method is inside AngleBrackets project under Util.cs which goes like this:
```C#

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
```
Simulation Result:
<img src='https://github.com/franciscohumarang/AngleBrackets/blob/master/Simulation.PNG'>



Unit Test Result:
![UnitTest](https://github.com/franciscohumarang/AngleBrackets/blob/master/UnitTest.PNG)


// Simulation
using AngleBrackets;

Console.WriteLine("Welcome to the Bracket Matching Checker!");
Console.WriteLine("Enter a string to check for matching angle brackets. Press 'Q' to quit.");

while (true)
{
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    if (input.ToUpper() == "Q")
    {
        break;
    }

    bool result = Util.MatchingTest(input);
    Console.WriteLine($"Input: '{input}' => Result: {result}");
}

Console.WriteLine("Thank you!");
    
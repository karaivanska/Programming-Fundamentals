using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class matchNumbers
{
    static void Main()
    {
        var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
        var numbers = Console.ReadLine();

        MatchCollection matches = Regex.Matches(numbers, pattern);

        foreach (Match match in matches)
        {
            Console.Write("{0} ", match.Value);
        }
        Console.WriteLine();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Cards
{
    static void Main()
    {
        string pattern = @"(?<=[SHDC]|^)(?<power>[2-9]|10|[JQKA])(?<suit>[HSCD])";
      
        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, pattern);

        var matchedCards = matches
            .Cast<Match>()
            .Select(x => x.Value)
            .ToArray();
        
        Console.WriteLine(string.Join(", ", matchedCards));
    }
}


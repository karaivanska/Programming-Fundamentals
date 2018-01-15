using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchFullName
{
    static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match name in matches)
        {
            Console.Write(name.Value + " ");
        }

        Console.WriteLine();
    }
}


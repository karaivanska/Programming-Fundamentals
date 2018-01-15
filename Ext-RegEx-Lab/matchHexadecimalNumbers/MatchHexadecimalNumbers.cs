using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchHexadecimalNumbers
{
    static void Main()
    {
        string pattern = @"\b(?:0x)?([0-9A-F]+)\b";
        string hexadecimal = Console.ReadLine();

        MatchCollection matches = Regex.Matches(hexadecimal, pattern);

        foreach (var match in matches)
        {
            Console.Write("{0} ", match);
        }
        Console.WriteLine();
    }
}


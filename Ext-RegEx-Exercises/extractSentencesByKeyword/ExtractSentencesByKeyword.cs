using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractSentencesByKeyword
{
    static void Main()
    {
        string input = Console.ReadLine(); //judge 60/100
        string text = Console.ReadLine();
        string pattern = string.Format(@"\s?[A-Z][^A-Z]+(?<=\s)[{0}]*(?=\s)[^.!]+[^.!?]", input);
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine("{0}", match.Value.TrimStart(' '));
        }
    }
}


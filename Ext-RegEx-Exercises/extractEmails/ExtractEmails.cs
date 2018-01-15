using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main()
    {
        string pattern = @"(?<=\s)(?<user>[a-z0-9]+([-.]\w*)*)@(?<host>\w{2,}([-.]\w*)*[a-z]*(\.[a-z]+))";

        string text = Console.ReadLine();

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (var match in matches)
        {
            Console.WriteLine("{0}", match);
        }
    }
}


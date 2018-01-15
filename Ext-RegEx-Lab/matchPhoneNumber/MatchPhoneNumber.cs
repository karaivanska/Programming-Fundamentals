using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchPhoneNumber
{
    static void Main()
    {
        var pattern = @"\+359(-| )2\1(\d{3})\1(\d{4})\b";
        var phones = Console.ReadLine();

        var matches = Regex.Matches(phones, pattern);

        var matchedPhones = matches
            .Cast<Match>()
            .Select(x => x.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class matchDates
{
    static void Main()
    {
        var pattern = @"(?<day>\d{2})(-|.|\/)(?<month>[A-Z]?[a-z]+)\1(?<year>\d{4})";

        var dates = Console.ReadLine();

        var matches = Regex.Matches(dates, pattern);

        foreach (Match match in matches)
        {
            var day = match.Groups["day"].Value;
            var month = match.Groups["month"].Value;
            var year = match.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}


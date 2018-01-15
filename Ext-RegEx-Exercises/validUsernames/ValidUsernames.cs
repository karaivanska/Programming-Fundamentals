using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ValidUsernames
{
    static void Main()
    {
        var data = new Dictionary<string, List<string>>();
        string text = Console.ReadLine();
        string pattern = @"(?<key>[a-zA-Z]+)[%20\s?\+]?=[%20\s?\+]?\d*(?<value>[\s?\+]*[\w:\/\/.*]+)&?[\s?\+]*";

        while (text != "END") //toLower?
        {
            MatchCollection matched = Regex.Matches(text, pattern);

            foreach (Match m in matched)
            {
                string key = m.Groups["key"].Value;
                string value = m.Groups["value"].Value;

                if (!data.ContainsKey(key))
                {
                    data.Add(key, new List<string>());
                }

                data[key].Add(value);
            }

            text = Console.ReadLine();
        }

        foreach (var kvp in data)
        {
            string key = kvp.Key;
            List<string> value = kvp.Value;

            Console.Write($"{key}=[{string.Join(", ", value)}]");

        }
    }
}


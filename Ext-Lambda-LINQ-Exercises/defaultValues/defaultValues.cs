using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class defaultValues
{
    static void Main()
    {
        var data = new Dictionary<string, string>();

        string[] input = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            string firstWord = input[0];
            string secondWord = input[1];

            if (!data.ContainsKey(firstWord))
            {
                data.Add(firstWord, secondWord);
            }

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }

        string inputToken = Console.ReadLine();

        var nonDefaultValues = data
            .Where(r => r.Value != "null")
            .OrderByDescending(r => r.Value.Length);

        var defaultValues = data
            .Where(r => r.Value == "null")
            .Select(r => new KeyValuePair<string, string>(r.Key, inputToken))
            .ToDictionary(r => r.Key, r => r.Value);

        foreach (var record in nonDefaultValues)
        {
            Console.WriteLine("{0} <-> {1}", record.Key, record.Value);
        }

        foreach (var record in defaultValues)
        {
            Console.WriteLine("{0} <-> {1}", record.Key, record.Value);
        }

    }
}


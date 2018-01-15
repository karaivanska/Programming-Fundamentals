using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SerializeString
{
    static void Main()
    {
        var chars = new Dictionary<char, List<string>>();
        string input = Console.ReadLine();
        int index = 0;
        int removedIndex = 0;

        foreach (var ch in input)
        {
            if (!chars.ContainsKey(ch))
            {
                chars.Add(ch, new List<string>());
                index = input.IndexOf(ch);
                chars[ch].Add(string.Join("", removedIndex));
                removedIndex++;
            }
            else
            {
                index = input.IndexOf(ch, input.Length - removedIndex);
                chars[ch].Add(string.Join("", removedIndex));
                removedIndex++;
            }
        }

        foreach (var kvp in chars)
        {
            char eachCharacter = kvp.Key;
            List<string> indexes = kvp.Value;

            Console.Write("{0}:{1}", eachCharacter, string.Join("/", indexes));
            Console.WriteLine();
        }
    }
}




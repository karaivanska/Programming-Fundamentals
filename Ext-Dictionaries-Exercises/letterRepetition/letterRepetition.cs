using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class letterRepetition
{
    static void Main()
    {
        Dictionary<string, int> text = new Dictionary<string, int>();
        string input = Console.ReadLine();

        foreach (var word in input)
        {
            if (!text.ContainsKey(word.ToString()))
            {
                text.Add(word.ToString(), 1);
            }
            else
            {
                text[word.ToString()]++;
            }
        }

        foreach (KeyValuePair<string, int> ch in text)
        {
            Console.WriteLine("{0} -> {1}", ch.Key, ch.Value);
        }
    }
}


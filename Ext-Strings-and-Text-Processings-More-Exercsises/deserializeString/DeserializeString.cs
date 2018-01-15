using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

class DeserializeString
{
    static void Main()
    {
        var data = new SortedDictionary<int, char>();
        string[] input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            char letter = input[0][0];
            int[] inputTokens = input[1].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (int token in inputTokens)
            {
                data[token] = letter;
            }

            input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine(data.Values.ToArray());
    }
}


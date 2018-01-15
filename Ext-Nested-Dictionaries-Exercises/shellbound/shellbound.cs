using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class shellbound
{
    static void Main()
    {
        var dictShell = new Dictionary<string, HashSet<int>>();
        string input = Console.ReadLine();

        while (input != "Aggregate") //check if needs to be toLower();
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string ragion = tokens[0];
            int shellSize = int.Parse(tokens[1]);

            if (!dictShell.ContainsKey(ragion))
            {
                dictShell.Add(ragion, new HashSet<int>());
            }

            dictShell[ragion].Add(shellSize);

            input = Console.ReadLine();
        }

        foreach (var kvp in dictShell)
        {
            string ragion = kvp.Key;
            HashSet<int> sizes = kvp.Value;
            string output = string.Join(", ", sizes);
            int result = 0;

            double avg = sizes.Average();
            int sizesSum = sizes.Sum();
            result = (int)Math.Ceiling(sizesSum - avg);

            Console.Write("{0} -> ", ragion);
            Console.Write("{0} ({1})", output, result);
            Console.WriteLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class dictRefAdvanced
{
    static void Main()
    {
        var keyValueDict = new Dictionary<string, List<int>>();

        string[] inputTokens = Console.ReadLine()
            .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

        while (!IsEnd(inputTokens[0]))
        {
            string name = inputTokens[0];
            string args = inputTokens[1];

            List<int> numsToAdd = ExtractNumbers(keyValueDict, args);
            StoreNumbers(keyValueDict, name, numsToAdd);

            inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var record in keyValueDict)
        {
            string name = record.Key;
            List<int> nums = record.Value;

            Console.WriteLine("{0} === {1}", name, string.Join(", ", nums));
        }
    }

    static void StoreNumbers(Dictionary<string, List<int>> keyValueDict, string name, List<int> numsToAdd)
    {
        if (numsToAdd.Count == 0)
        {
            return;
        }

        if (!keyValueDict.ContainsKey(name))
        {
            keyValueDict.Add(name, new List<int>());
        }

        keyValueDict[name].AddRange(numsToAdd);
    }

    static List<int> ExtractNumbers(Dictionary<string, List<int>> keyValueDict, string args)
    {
        if (IsName(args))
        {
            string otherName = args;

            if (keyValueDict.ContainsKey(otherName))
            {
                return keyValueDict[otherName];
            }
            else
            {
                return new List<int>();
            }
        }
        else
        {
            return ParsedNumbers(args);
        }
    }

    static List<int> ParsedNumbers(string args)
    {
        return args.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    }

    static bool IsName(string args)
    {
        foreach (var ch in args)
        {
            if (char.IsLetter(ch))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsEnd(string inputToken)
    {
        return  inputToken == "end";
    }
}





    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class mixedPhones
{
    static void Main()
    {
        SortedDictionary<string, long> nameDict = new SortedDictionary<string, long>();
        var input = Console.ReadLine();

        while (input != "Over")
        {
            var commandArgs = input.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = String.Empty;
            string value = String.Empty;
            if (CheckValue(commandArgs[0]))
            {
                 name = commandArgs[0];
                 value = commandArgs[1];
            }
            else
            {
                value = commandArgs[0];
                name = commandArgs[1];
            }

            long num;
            long.TryParse(value, out num);

            if (!nameDict.ContainsKey(name))
            {

                nameDict.Add(name, num);
            }
            else
            {
                nameDict[name] = num;
            }

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, long> name in nameDict)
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }
    }

    private static bool CheckValue(string commandArgs)
    {
        foreach (var ch in commandArgs)
        {
            if (char.IsLetter(ch))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class dictRef
{
    private static int value;

    static void Main()
    {
        Dictionary<string, int> nameDict = new Dictionary<string, int>();
        var input = Console.ReadLine();

        while (input != "end")
        {
            var commandArgs = input.Split(new char[] {' ', '='}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = commandArgs[0];
            string value = commandArgs[1];
            int number;

            if (int.TryParse(value, out number))
            {
                nameDict[name] = number;
            }
            else
            {
                if (nameDict.ContainsKey(value))
                {
                    nameDict[name] = nameDict[value];
                }
            }

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> item in nameDict)
        {
            Console.WriteLine($"{item.Key} === {item.Value}");
        }
    }
    
}

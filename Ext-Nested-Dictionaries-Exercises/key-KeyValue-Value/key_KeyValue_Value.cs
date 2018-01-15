using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var keyValueDict = new Dictionary<string, List<string>>();
        string key = Console.ReadLine();
        string value = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] inputTokens =
                Console.ReadLine().Split(new string[] {" => "}, StringSplitOptions.RemoveEmptyEntries);

            string inputKey = inputTokens[0];
            string[] inputValues = inputTokens[1].Split(new char[] {';', ' '}, StringSplitOptions.RemoveEmptyEntries);

            if (inputKey.Contains(key))
            {
                if (!keyValueDict.ContainsKey(inputKey))
                {
                    keyValueDict.Add(inputKey, new List<string>());
                }

                foreach (var itemValue in inputValues)
                {
                    if (itemValue.Contains(value))
                    {
                        if (!keyValueDict[inputKey].Contains(itemValue))
                        {
                            keyValueDict[inputKey].Add(itemValue);
                        }
                        else
                        {
                            keyValueDict[inputKey].Add(itemValue);
                        }
                    }
                }
            }
        }

        foreach (var item in keyValueDict)
        {
            string keyName = item.Key;
            List<string> valueName = item.Value;

            Console.WriteLine("{0}:", keyName);
            
            foreach (var eachValue in valueName)
            {
                Console.WriteLine("-{0}", eachValue);
            }
        }
    }
}


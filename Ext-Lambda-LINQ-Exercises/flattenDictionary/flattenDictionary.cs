using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class flattenDictionary
{
    static void Main()
    {
        var products = new Dictionary<string, Dictionary<string, string>>();
        var concatWords = new Dictionary<string, List<string>>();

        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (!IsEnd(input[0]))
        {
            if (IsInputFlatten(input[0]))
            {
                foreach (var record in products)
                {
                    string key = record.Key;

                    if (key == input[1])
                    {
                        Dictionary<string, string> innerValues = record.Value;

                        foreach (var innerValue in innerValues)
                        {
                            string flattenValue = innerValue.Key + innerValue.Value;

                            if (!concatWords.ContainsKey(key))
                            {
                                concatWords.Add(key, new List<string>());
                            }

                            concatWords[key].Add(flattenValue);
                        }
                    }
                }

                products[input[1]] = new Dictionary<string, string>();
            }

            else
            {
                string key = input[0];
                string innerKey = input[1];
                string innerValue = input[2];

                if (!products.ContainsKey(key))
                {
                    products.Add(key, new Dictionary<string, string>());
                    products[key].Add(innerKey, innerValue);
                }

                if (products[key].ContainsKey(innerKey))
                {
                    products[key][innerKey] = innerValue;
                }
                else
                {
                    products[key].Add(innerKey, innerValue);
                }
            }

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        PrintResults(concatWords, products);
    }

    static void PrintResults(Dictionary<string, List<string>> concatWords, Dictionary<string, Dictionary<string, string>> products)
    {
        foreach (var item in products.OrderByDescending(x => x.Key.Length))
        {
            string key = item.Key;
            Dictionary<string, string> values = item.Value;

            Console.WriteLine("{0}", key);

            int count = 1;
            foreach (var kvp in values.OrderBy(x => x.Key.Length))
            {
                Console.WriteLine("{0}. {1} - {2}", count, kvp.Key, kvp.Value);
                ++count;
            }

            if (concatWords.ContainsKey(key))
            {
                foreach (var word in concatWords[key])
                {
                    Console.WriteLine("{0}. {1}", count, word);
                    ++count;
                }
            }
        }
    }

    static bool IsEnd(string input)
    {
        return input == "end";
    }

    static bool IsInputFlatten(string input)
    {
        if (input == "flatten")
        {
            return true;
        }

        return false;
    }
}


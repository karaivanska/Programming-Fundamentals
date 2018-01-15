using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
    static Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

    static string dataKey = string.Empty;
    static long dataSize = 0;

    static void Main()
    {
        data = new Dictionary<string, Dictionary<string, long>>();
        cache = new Dictionary<string, Dictionary<string, long>>();

        var input = Console.ReadLine();

        while (!IsTheTin(input))
        {
            if (IsTheInputBigLenght(input))
            {
                ProcessBigLenght(input);
            }

            else
            {
                ProcessSmallLenght(input);
            }

            input = Console.ReadLine();
        }

        PrintOutput(data);
    }

    static void PrintOutput(Dictionary<string, Dictionary<string, long>> dictionary)
    {
        foreach (var item in data.OrderByDescending(x => x.Value.Values.Sum()).Take(1))
        {
            string set = item.Key;
            Dictionary<string, long> dataValues = item.Value;
            long sum = item.Value.Values.Sum();

            Console.WriteLine("Data Set: {0}, Total Size: {1}", set, sum);

            foreach (var kvp in dataValues)
            {
                string user = kvp.Key;

                Console.WriteLine("$.{0}", user);
            }
        }
    }

    static void ProcessSmallLenght(string input)
    {
        string dataSet = input;  // Maybe problem in the code!

        if (!data.ContainsKey(dataSet))
        {
            data.Add(dataSet, new Dictionary<string, long>());
            if (cache.ContainsKey(dataSet) && cache[dataSet] != null)
            {
                foreach (var kvp in cache)
                {
                    Dictionary<string, long> datas = kvp.Value;

                    foreach (var item in datas)
                    {
                        string key = item.Key;
                        long size = item.Value;

                        data[dataSet][key] = size;
                    }
                }
            }
        }

        else
        {
            if (cache.ContainsKey(dataSet))
            {
                data[dataSet][dataKey] = dataSize;
            }
        }
    }

    static void ProcessBigLenght(string input)
    {
        string[] firstTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        dataKey = firstTokens[0];
        string[] dataValues =
            firstTokens[1].Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        dataSize = long.Parse(dataValues[0]);
        string dataSet = dataValues[1];

        if (data.ContainsKey(dataSet))
        {
            data[dataSet].Add(dataKey, dataSize);
        }
        else
        {
            if (!cache.ContainsKey(dataSet))
            {
                cache.Add(dataSet, new Dictionary<string, long>());
                cache[dataSet].Add(dataKey, dataSize);
            }

            if (cache[dataSet].ContainsKey(dataKey))
            {
                cache[dataSet][dataKey] = dataSize;
            }
            else
            {
                cache[dataSet].Add(dataKey, dataSize);
            }
        }
    }

    static bool IsTheInputBigLenght(string input)
    {
        if (input.Contains("->"))
        {
            return true;
        }

        return false;
    }

    static bool IsTheTin(string input)
    {
        return input == "thetinggoesskrra";
    }
}
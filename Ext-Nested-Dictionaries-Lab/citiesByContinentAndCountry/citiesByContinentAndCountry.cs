using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class citiesByContinentAndCountry
{
    static void Main()
    {
        var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!continentsData.ContainsKey(continent))
            {
                continentsData.Add(continent, new Dictionary<string, List<string>>());
                continentsData[continent].Add(country, new List<string>());
            }

            if (!continentsData[continent].ContainsKey(country))
            {
                continentsData[continent].Add(country, new List<string>());
                continentsData[continent][country].Add(city);
            }
            else
            {
                continentsData[continent][country].Add(city);
            }
        }

        foreach (var item in continentsData)
        {
            string continent = item.Key;
            Dictionary<string, List<string>> countries = item.Value;

            Console.WriteLine("{0}:", continent);

            foreach (var pair in countries)
            {
                string country = pair.Key;
                List<string> city = pair.Value;

                Console.WriteLine("{0} -> {1}", country, string.Join(", ", city));
            }
        }
    }
}


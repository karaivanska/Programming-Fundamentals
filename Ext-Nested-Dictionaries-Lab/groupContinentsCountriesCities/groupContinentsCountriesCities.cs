using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class groupContinentsCountriesCities
{
    static void Main()
    {
        var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!continentsData.ContainsKey(continent))
            {
                continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                continentsData[continent].Add(country, new SortedSet<string>());
            }
            if (!continentsData[continent].ContainsKey(country))
            {
                continentsData[continent].Add(country, new SortedSet<string>());
                continentsData[continent][country].Add(city);
            }

            continentsData[continent][country].Add(city);
        }
        
        foreach (var item in continentsData)
        {
            string continent = item.Key;
            SortedDictionary<string, SortedSet<string>> countries = item.Value;

            Console.WriteLine("{0}:", continent);

            foreach (var kvp in countries)
            {
                string country = kvp.Key;
                SortedSet<string> city = kvp.Value;

                Console.WriteLine("{0} -> {1}", country, string.Join(", ", city));
            }
        }
    }
}


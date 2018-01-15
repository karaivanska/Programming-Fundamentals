using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class Weather
{
    static void Main()
    {
        var weatherForecast = new Dictionary<string, Dictionary<double, string>>();
        string pattern = @"(?<city>[A-Z]{2})(?<temp>[0-9.]+)(?<weather>[A-Za-z]+)\|";
        string input = Console.ReadLine();

        while (input != "end")
        {
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string city = match.Groups["city"].ToString();
                double temp = double.Parse(match.Groups["temp"].ToString());
                string weather = match.Groups["weather"].ToString();

                if (!weatherForecast.ContainsKey(city))
                {
                    weatherForecast.Add(city, new Dictionary<double, string>());
                   weatherForecast[city][temp] = weather;
                }
                else
                {
                    if (!weatherForecast[city].ContainsKey(temp) || !weatherForecast[city].ContainsValue(weather))
                    {
                        weatherForecast[city].Clear();
                        weatherForecast[city][temp] = weather;
                    }
                }
            }

            input = Console.ReadLine();
        }
        
        foreach (var item in weatherForecast.OrderBy(x => x.Value.Keys.Max()))
        {
            string city = item.Key;
            Dictionary<double, string> weatherData = item.Value;

            Console.Write("{0} => ", city);

            foreach (var kvp in weatherData)
            {
                double temp = kvp.Key;
                string weather = kvp.Value;

                Console.Write("{0:F2} => {1}", temp, weather);
            }

            Console.WriteLine();
        }
    }
}


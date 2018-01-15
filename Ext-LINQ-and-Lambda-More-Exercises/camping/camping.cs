using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class camping
{
    static void Main()
    {
        var campersData = new Dictionary<string, Dictionary<string, int>>();

        string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            string personName = input[0];
            string camperModel = input[1];
            int countStayedDays = int.Parse(input[2]);

            if (!campersData.ContainsKey(personName))
            {
                campersData.Add(personName, new Dictionary<string, int>());
            }

            if (!campersData[personName].ContainsKey(camperModel))
            {
                campersData[personName].Add(camperModel, countStayedDays);
            }
            else
            {
                campersData[personName][camperModel] += countStayedDays;
            }

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var item in campersData.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key.Length))
        {
            string name = item.Key;
            Dictionary<string, int> datasCamper = item.Value;
            int nights = item.Value.Values.Sum();

            Console.WriteLine("{0}: {1}", name, item.Value.Count);
            foreach (var kvp in datasCamper)
            {
                string camper = kvp.Key;
                Console.WriteLine("***{0}", camper);
            }

            Console.WriteLine("Total stay: {0} nights", nights);
        }
    }
}


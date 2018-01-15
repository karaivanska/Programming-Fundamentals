using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var buildings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        int camelBack = int.Parse(Console.ReadLine());
        int round = 0;
        List<int> result = buildings.ToList();

        while (result.Count > camelBack)
        {
            result.Remove(result.First());
            result.Remove(result.Last());
            round++;
        }
         
        if (buildings.Count == camelBack)
        {
            Console.WriteLine($"already stable: {string.Join(" ", result)}");
        }

        else
        {
            Console.WriteLine($"{round} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", result)}");
        }
    }
}


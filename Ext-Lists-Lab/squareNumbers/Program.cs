using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToList();

       List<long> results = new List<long>();
        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) == (long) Math.Sqrt(num))
            {
                results.Add(num);
            }
        }

        results.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine(string.Join(" ", results));
    }
}


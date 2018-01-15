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
            .Select(double.Parse).ToList();

        numbers.Sort((a, b) => a.CompareTo(b));

        var count = new Dictionary<double, long>();


        foreach (var num in numbers)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        foreach (var number in count.Keys)
        {
            Console.WriteLine($"{number} -> {count[number]}");
        }
    }
}


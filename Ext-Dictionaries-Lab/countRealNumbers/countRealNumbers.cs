using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class countRealNumbers
{
    static void Main()
    {
        SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

        var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

        for (int i = 0; i < input.Count; i++)
        {
            if (!numbers.ContainsKey(input[i]))
            {
                numbers.Add(input[i], 1);
            }
            else
            {
                numbers[input[i]]++;
            }
        }

        foreach (KeyValuePair<double, int> num in numbers)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}


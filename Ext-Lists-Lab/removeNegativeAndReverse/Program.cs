using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
        List<long> results = new List<long>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0)
            {
                results.Add(numbers[i]);
            }
        }

        results.Reverse();
        if (IsEmptyList(results) == false)
        {
            Console.WriteLine(string.Join(" ", results));
        }
        else
        {
            Console.WriteLine("empty");
        }
        
    }

    private static bool IsEmptyList(List<long> results)
    {
        for (int i = 0; i < results.Count; i++)
        {
            if (results[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}


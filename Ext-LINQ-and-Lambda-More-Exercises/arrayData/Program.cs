using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<long> numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
        string command = Console.ReadLine();

        double avgNum = numbers.Average();

        while (IsHaveSmallerNumber(numbers, avgNum))
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < avgNum)
                {
                    numbers.Remove(numbers[i]);
                }
            }
        }

        switch (command)
        {
           case "Min":
                Console.WriteLine("{0}", numbers.Min());
               break;

            case "Max":
                Console.WriteLine("{0}", numbers.Max());
                break;

            case "All":
                Console.WriteLine("{0}", string.Join(" ", numbers.OrderBy(x => x)));
                break;
        }
    }

    static bool IsHaveSmallerNumber(List<long> numbers, double avgNum)
    {
        foreach (var num in numbers)
        {
            if (num < avgNum)
            {
                return true;
            }
        }

        return false;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int smallestElement = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < smallestElement)
            {
                smallestElement = numbers[i];
            }
        }

        Console.WriteLine($"{smallestElement}");
    }
}

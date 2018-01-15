using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class countGivenElementInArray
{
    static void Main()
    {
        var sequence = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        int numberOfElement = int.Parse(Console.ReadLine());

        long counter = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == numberOfElement)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}


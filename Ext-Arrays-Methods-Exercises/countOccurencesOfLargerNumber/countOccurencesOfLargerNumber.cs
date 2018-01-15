using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class countOccurencesOfLargerNumber
{
    static void Main()
    {
        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        double p = double.Parse(Console.ReadLine());

        long counter = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > p)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse)
            .ToList();

        bool hasSummed = true;

        while (hasSummed)
        {
            hasSummed = false;
            int index = 0;
            long sum = 0;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    index = i - 1;
                    sum = input[i] + input[i - 1];
                    hasSummed = true;
                    break;
                }
            }

            if (hasSummed)
            {
                input.RemoveRange(index, 2);
                input.Insert(index, sum);
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }
}


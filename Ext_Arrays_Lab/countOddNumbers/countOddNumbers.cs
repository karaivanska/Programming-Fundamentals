using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int countOddNums = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 2 != 0)
            {
                countOddNums++;
            }
        }

        Console.WriteLine(countOddNums);
    }
}


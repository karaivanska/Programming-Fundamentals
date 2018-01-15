using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class countOddNumbersAndOddPositions
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0 && input[i] % 2 != 0)
            {
                int index = i;
                int num = input[i];

                Console.WriteLine($"Index {index} -> {num}");
            }
        }
    }
}


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
            .Select(int.Parse).ToList();

        string input = Console.ReadLine();

        while (input != "end")
        {
            int currentNum = int.Parse(input);
            int firstDigit = currentNum;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == firstDigit)
                {
                    numbers.Insert(firstDigit, currentNum);
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}


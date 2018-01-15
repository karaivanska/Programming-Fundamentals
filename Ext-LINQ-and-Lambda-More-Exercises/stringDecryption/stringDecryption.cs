using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class stringDecryption
{
    static void Main()
    {
        int[] manipulatingNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        int elementsToSkip = manipulatingNumbers[0];
        int elementsToTake = manipulatingNumbers[1];

        numbers = numbers.Where(n => n >= 65 && n <= 90)
            .Skip(elementsToSkip)
            .Take(elementsToTake)
            //.Distinct()
            .ToList();

        foreach (var num in numbers)
        {
            Console.Write((char) num);
        }
        Console.WriteLine();
    }
}


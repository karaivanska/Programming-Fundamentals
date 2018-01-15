using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class largestElementInArray
{
    static void Main()
    {
        int limitOfNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[limitOfNumbers];
        int maxNumber = int.MinValue;

        for (int i = 0; i < limitOfNumbers; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        Console.WriteLine(maxNumber);
    }
}


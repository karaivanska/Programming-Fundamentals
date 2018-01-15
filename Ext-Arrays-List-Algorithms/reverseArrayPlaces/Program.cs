using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int left = 0;
        int right = numbers.Length - 1;

        while (left >= right)
        {
            int tmp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = tmp;

            left++;
            right--;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}


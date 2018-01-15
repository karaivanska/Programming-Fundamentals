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

        int firstNElements = int.Parse(Console.ReadLine());

        List<int> result = new List<int>(firstNElements);

        BubleSort(numbers, firstNElements, result);

        //Console.WriteLine(string.Join(" ", result));
    }

    private static void BubleSort(int[] numbers, int firstNElements, List<int> result)

    {
        bool isSwapped = true;
        while (true)
        {
            isSwapped = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    Swap(ref numbers[i], ref numbers[i + 1]);
                    isSwapped = true;
                }
            }

            if (!isSwapped)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers.Take(firstNElements)));
    }

    private static void Swap(ref int leftElement, ref int rightElement)
    {
        int tmp = leftElement;
        leftElement = rightElement;
        rightElement = tmp;
    }
}

   




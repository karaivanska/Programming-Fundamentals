using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();

        bool isSwapped = true;
        while (true)
        {
            isSwapped = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(ref arr[i], ref arr[i + 1]);
                    isSwapped = true;
                }
            }

            if (!isSwapped)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", arr));
    }

    private static void Swap(ref int leftElement, ref int rightElement)
    {
        int tmp = leftElement;
        leftElement = rightElement;
        rightElement = tmp;
    }
}


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

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    Swap(ref arr[i], ref arr[i - 1]);
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
        int tmp = rightElement;
        rightElement = leftElement;
        leftElement = tmp;
    }
}


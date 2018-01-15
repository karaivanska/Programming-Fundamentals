using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class minMethod
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int minValue = GetMin(num1, num2);

        if (num3 > minValue)
        {
            Console.WriteLine(minValue);
        }
        else
        {
            Console.WriteLine(num3);
        }
    }

    private static int GetMin(int num1, int num2)
    {
        int minValue = 0;
        int[] arr = {num1, num2};

        minValue = arr.Min();
        return minValue;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class findNDigit
{
    static void Main()
    {
        var num = long.Parse(Console.ReadLine());

        long index = long.Parse(Console.ReadLine());

        long findedNum = FindNthDigit(num, index);
        Console.WriteLine(findedNum);
    }

    private static long FindNthDigit(long num, long index)
    {
        long result = 0;
        long count = 0;
        long temp = 0;

        while (num != 0)
        {
            temp = num % 10;
            count++;

            if (count == index)
            {
                return temp;
            }
            else
            {
                result = num / 10;
                num = result;
            }
        }

        return num % 10;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class integerToBase
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long based = long.Parse(Console.ReadLine());

        string result = CalcTheBase(number, based);
        Console.WriteLine(result);
    }

    private static string CalcTheBase(long number, long based)
    {
        long remainder = 0;
        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % based;
            result = remainder + result;
            number /= based;
        }

        return result;
    }
}


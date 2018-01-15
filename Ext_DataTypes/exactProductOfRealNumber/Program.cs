using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal firstNum = decimal.Parse(Console.ReadLine());

        decimal result = firstNum;

        for (int i = 0; i < n - 1 ; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            result *= number;
        }

        Console.WriteLine(result);
    }
}


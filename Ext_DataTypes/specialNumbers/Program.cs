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
        int num = 0;
        int sum = 0;
        bool isSpecial;

        for (int i = 1; i <= n; i++)
        {
            sum = i;
            while (i > 0)
            {
                num += i % 10;
                i = i / 10;
            }
            isSpecial = (num == 5) || (num == 7) || (num == 11);
            Console.WriteLine($"{sum} -> {isSpecial}");
            num = 0;
            i = sum;
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class multiplyArrayOfDoubles
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        
        double p = double.Parse(Console.ReadLine());

        for (int i = 0; i < input.Length; i++)
        {
            input[i] *= p;
        }

        Console.WriteLine(string.Join(" ", input));
    }
}


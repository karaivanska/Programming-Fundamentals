using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double circle = 2 * Math.PI * r;

        Console.WriteLine($"{circle:F12}");
    }
}


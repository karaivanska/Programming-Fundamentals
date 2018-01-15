using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int[] arr = {a, b, c};
        arr = arr.OrderBy(number => number).ToArray();

        int sideA = arr[0];
        int sideB = arr[1];
        int sideC = arr[2];

        bool valid = false;

        bool rightAngle = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);

        if ((a + b) > c)
        {
            if ((b + c) > a)
            {
                if ((a + c) > b)
                {
                    valid = true;
                }
            }
        }

        if (valid)
        {
            Console.WriteLine("Triangle is valid.");

            if (rightAngle)
            {
                if (c > a && c > b)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }
    }
}


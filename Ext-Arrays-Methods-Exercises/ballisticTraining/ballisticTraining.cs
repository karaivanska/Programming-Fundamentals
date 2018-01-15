using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ballisticTraining
{
    static void Main()
    {
        var firstArr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToArray();

        var secondArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var target = firstArr[0];
        var coordinates = firstArr[1];

        long x = 0;
        long y = 0;

        for (int i = 0; i < secondArr.Length; i++)
        {
            if (i % 2 == 0)
            {
                var command = secondArr[i];

                if (command == "right")
                {
                    x += Convert.ToInt64(secondArr[i + 1]);
                }
                else if (command == "left")
                {
                    x -= Convert.ToInt64(secondArr[i + 1]);
                }
                else if (command == "up")
                {
                    y += Convert.ToInt64(secondArr[i + 1]);
                }
                else if (command == "down")
                {
                    y -= Convert.ToInt64(secondArr[i + 1]);
                }
            }
        }

        if (x == target && y == coordinates)
        {
            Console.WriteLine($"firing at [{x}, {y}]");
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine($"firing at [{x}, {y}]");
            Console.WriteLine("better luck next time...");
        }
    }
}


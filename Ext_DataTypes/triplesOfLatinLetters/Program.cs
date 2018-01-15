using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        char letter = (char) ('a' + num);

        for (char i = 'a'; i < letter; i++)
        {
            for (char j = 'a'; j < letter; j++)
            {
                for (char k = 'a'; k < letter; k++)
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
            }
        }
    }
}


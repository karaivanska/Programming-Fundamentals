using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class smallestElementInArray
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(string.Join(" ", input.Min()));
    }
}


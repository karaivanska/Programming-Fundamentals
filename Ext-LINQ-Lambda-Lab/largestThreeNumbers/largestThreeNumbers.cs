using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class largestThreeNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
        Console.WriteLine(string.Join(" ", numbers));
    }
}


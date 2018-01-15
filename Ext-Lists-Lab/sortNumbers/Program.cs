using System;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();

        numbers.Sort();
        Console.WriteLine(string.Join(" <= ", numbers));

    }
}


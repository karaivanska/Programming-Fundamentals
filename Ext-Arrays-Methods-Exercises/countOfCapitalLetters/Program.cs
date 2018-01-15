using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var str = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

        bool isUpper = false;
        long count = 0;

        foreach (var word in str)
        {
            if (word.Length < 2)
            {
                isUpper = true;
                count++;
            }
        }

        Console.WriteLine(count);
    }
}


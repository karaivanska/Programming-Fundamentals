using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split('|').ToList();

        list.Reverse();
        var result = string.Join(" ", list.Select(s => s.Trim()).ToList());

        Console.WriteLine(result);
    }
}


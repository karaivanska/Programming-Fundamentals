using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        double terabytes =  n * 8796093022208;

        Console.WriteLine(terabytes);
    }
}


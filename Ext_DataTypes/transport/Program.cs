using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numOfPeople = 24;

        double result = 0;

        result = Math.Ceiling((double) n / numOfPeople);

        Console.WriteLine(result);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());

        int days = n * 365;
        int hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine($"{n} years = {days} days = {hours} hours = {minutes} minutes.");
    }
}


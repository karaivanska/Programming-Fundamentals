using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class helloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        var theName = PrintName(name);
        Console.WriteLine(theName);
    }

    private static string PrintName(string name)
    {
        string greeting = "Hello," + " " + name + "!";
        return greeting;
    }
}


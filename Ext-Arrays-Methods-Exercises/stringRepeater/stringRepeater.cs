using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class stringRepeater
{
    static void Main()
    {
        string str = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        string repeater = StringRepeater(str, num);
        Console.WriteLine(repeater);
    }

    private static string StringRepeater(string str, int num)
    {
        string result = "";
        for (int i = 0; i < num; i++)
        {
            result += str;
        }

        return result;
    }
}


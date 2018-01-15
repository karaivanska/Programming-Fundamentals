using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class rotateElements
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        string[] newArr = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            newArr[(i + 1) % input.Length] = input[i];
        }

        Console.WriteLine(string.Join(" ", newArr));
    }
}


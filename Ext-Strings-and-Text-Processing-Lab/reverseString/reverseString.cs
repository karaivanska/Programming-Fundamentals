using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class reverseString
{
    static void Main()
    {
        string word = Console.ReadLine();
        string reversed = new string(word.Reverse().ToArray());

        Console.WriteLine(reversed);
    }
}


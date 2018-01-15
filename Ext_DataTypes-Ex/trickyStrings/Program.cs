using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var delimiter = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());
        string sumOfWords = "";

        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            sumOfWords += input + delimiter;
        }

        Console.WriteLine(sumOfWords.TrimEnd(delimiter.ToCharArray()));
    }
}


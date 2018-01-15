using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string ascii = "";
        for (int i = 0; i < num; i++)
        {
           int inputNums = int.Parse(Console.ReadLine());
            ascii += Convert.ToChar(inputNums);
        }

        Console.WriteLine(ascii);
    }
}


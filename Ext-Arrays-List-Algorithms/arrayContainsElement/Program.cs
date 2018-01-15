using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] firstArr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int findNumber = int.Parse(Console.ReadLine());

        bool isContained = false;
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] == findNumber)
            {
                isContained = true;
            }
        }

        if (isContained)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}


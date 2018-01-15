using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class increasingSequenceOfElements
{
    static void Main()
    {
        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
       
        bool isIncreasing = false;
        int firstNum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (i < 1)
            {
                firstNum = sequence[i];
            }
            else
            {
                if (firstNum < sequence[i])
                {
                    isIncreasing = true;
                    firstNum = sequence[i];
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }
        }

        if (isIncreasing)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}


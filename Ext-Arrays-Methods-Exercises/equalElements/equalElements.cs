using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class equalElements
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToArray();

        long previousNum = 0;
        bool isEqual = false;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (i < 1)
            {
                previousNum = sequence[i];
            }
            else
            {
                if (previousNum == sequence[i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        
    }
}


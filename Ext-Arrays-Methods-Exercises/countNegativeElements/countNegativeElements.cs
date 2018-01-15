using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class countNegativeElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int negativeElements = 0;

        for (int i = 0; i < n; i++)
        {
            int elements = int.Parse(Console.ReadLine());

            if (elements < 0)
            {
                negativeElements++;
            }
        }
        Console.WriteLine(negativeElements);
    }
}


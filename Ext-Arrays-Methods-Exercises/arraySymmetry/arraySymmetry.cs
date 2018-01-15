using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class arraySymmetry
{
    static void Main()
    {
        var words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] reversed = new string[words.Length];

        bool isEqual = true;

        for (int i = 0; i < words.Length; i++)
        {
            reversed[i] = words[i];
        }

        Array.Reverse(reversed);

        for (int i = 0; i < words.Length; i++)
        {
            if (reversed[i] != words[i])
            {
                isEqual = false;
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


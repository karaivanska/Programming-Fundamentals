using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DiamondProblem
{
    static void Main()
    {
        string input = Console.ReadLine();
        int leftIndex = -1;
        int rightIndex = -1;
        bool isFound = false;

        while((leftIndex = input.IndexOf('<', leftIndex + 1)) > - 1 && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
        {
            string diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
            int carats = CalculateCarats(diamondContent);
            isFound = true;
            Console.WriteLine($"Found {carats} carat diamond");
        }

        if (!isFound)
        {
            Console.WriteLine("Better luck next time");
        }
    }

    static int CalculateCarats(string diamondContent)
    {
        int carats = 0;

        foreach (char @char in diamondContent)
        {
            if (char.IsDigit(@char))
            {
                carats += int.Parse(@char.ToString());
            }
        }

        return carats;
    }
}


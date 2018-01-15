using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

class Nilapdrome
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string nilaprdrome = FindNilapdrome(input);

            if (nilaprdrome != "")
            {
                Console.WriteLine(nilaprdrome);
            }

            input = Console.ReadLine();
        }
    }

    static string FindNilapdrome(string input)
    {
        int middleIndex = input.Length / 2;
        string border = "";
        int leftIndex = 0;

        for (int i = middleIndex + 1; i < input.Length; i++)
        {
            if (input[leftIndex] == input[i])
            {
                border += input[i];
                leftIndex++;
            }

            else
            {
                border = "";
                leftIndex = 0;

                if (input[i] == input[leftIndex])
                {
                    border += input[i];
                    leftIndex++;
                }
            }
        }

        if (border != "")
        {
            int leftMidIndex = input.IndexOf(border);
            int rightMidIndex = input.IndexOf(border);

            string middle = input.Substring(leftMidIndex + border.Length, rightMidIndex - leftMidIndex - border.Length);

            if (middle != "")
            {
                return middle + border + middle;
            }
        }
        return "";
    }
}


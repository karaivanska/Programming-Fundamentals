using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class stringEncryption
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        CreateEncryption(num);
    }

    private static void CreateEncryption(long num)
    {
        var result = new StringBuilder();
        for (int i = 0; i < num; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            long numOfLetter = letter;

            if (numOfLetter > 99)
            {
                long firstDigit = numOfLetter / 100;
                long lastDigit = numOfLetter % 10;
                long middleOfDigits = long.Parse(firstDigit.ToString() + lastDigit.ToString());
                char firstLetter = (char) (numOfLetter + lastDigit);
                char lastLetter = (char) (numOfLetter - firstDigit);
                result.Append(firstLetter);
                result.Append(middleOfDigits);
                result.Append(lastLetter);
            }
            else if (numOfLetter >= 0  && numOfLetter < 100)
            {
                long firstDigit = numOfLetter / 10;
                long lastDigit = numOfLetter % 10;
                long middleOfDigits = long.Parse(firstDigit.ToString() + lastDigit.ToString());
                char firstLetter = (char)(numOfLetter + lastDigit);
                char lastLetter = (char)(numOfLetter - firstDigit);
                result.Append(firstLetter);
                result.Append(middleOfDigits);
                result.Append(lastLetter);
            }
        }

        Console.WriteLine(result);
    }
}


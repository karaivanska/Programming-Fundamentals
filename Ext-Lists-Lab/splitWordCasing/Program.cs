using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine().Split(new char[]
                {',', ';', ',', ':', '.', '!', '(', ')', '"', '\\', '\\', '/', '[', ']', ' '},
            StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        for (int i = 0; i < text.Count; i++)
        {
            string currentWord = text[i];

            if (IsLowerChars(currentWord))
            {
                lowerCase.Add(currentWord);
            }
            else if (IsUpperCase(currentWord))
            {
                upperCase.Add(currentWord);
            }
            else
            {
                mixedCase.Add(currentWord);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");

    }

    private static bool IsUpperCase(string currentWord)
    {
        bool isUpper = false;
        foreach (var ch in currentWord)
        {
            if (char.IsUpper(ch))
            {
                isUpper = true;
            }
            else
            {
                isUpper = false;
                return false;
            }
        }

       return isUpper;
    }

    private static bool IsLowerChars(string currentWord)
    {
        bool isLower = false;

        foreach (var ch in currentWord)
        {

            if (char.IsLower(ch))
            {
                isLower = true;
            }
            else
            {
                isLower = false;
                return false;
            }
        }

        return isLower;
    }
}



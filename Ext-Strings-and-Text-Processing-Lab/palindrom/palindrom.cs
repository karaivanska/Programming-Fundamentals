using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class palindrom
{
    static void Main()
    {
        string[] tokens = Console.ReadLine()
            .Split(new string[] {",", " ", ".", "!", "?"}, StringSplitOptions.RemoveEmptyEntries);

        SortedSet<string> palindroms = new SortedSet<string>();
        foreach (var token in tokens)
        {
            if (IsPalindrom(token))
            {
                palindroms.Add(token);
            }
        }

        Console.WriteLine(string.Join(", ", palindroms));
    }

    static bool IsPalindrom(string token)
    {
        for (int i = 0; i < token.Length/2; i++)
        {
            if (token[i] != token[token.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}


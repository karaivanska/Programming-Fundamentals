using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class textFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            string replacement = new string('*', word.Length);
            text = text.Replace(word, replacement);
        }

        Console.WriteLine(text);
    }
}


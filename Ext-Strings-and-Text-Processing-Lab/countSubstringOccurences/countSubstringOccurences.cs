using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class countSubstringOccurences
{
    static void Main()
    {
        string text = Console.ReadLine()
            .ToLower();
        string searchingWord = Console.ReadLine().ToLower();

        int index = text.IndexOf(searchingWord);
        int counter = 0;

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(searchingWord, index + 1);
        }

        Console.WriteLine(counter);
    }
}


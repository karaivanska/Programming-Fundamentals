using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class findTheLetter
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] occurences = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        char letter = char.Parse(occurences[0]);
        int numberToSkip = int.Parse(occurences[1]);

        int index = -1;
        do
        {
            numberToSkip--;
            index = text.IndexOf(letter, index + 1);
        } while (index != -1 && numberToSkip > 0);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Find the letter yourself!");
        }
    }
}


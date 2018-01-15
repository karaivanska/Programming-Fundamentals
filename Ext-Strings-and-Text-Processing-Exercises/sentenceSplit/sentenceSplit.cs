using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SentenceSplit
{
    static void Main()
    {
        string text = Console.ReadLine();
        string delimiter = Console.ReadLine();
        string[] textResult = text.Split(new string[] {delimiter}, StringSplitOptions.None);

        Console.WriteLine($"[{string.Join(", ", textResult)}]");
    }
}

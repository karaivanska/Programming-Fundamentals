using System;
using System.Collections.Generic;
using System.Linq;

class shortWordsSorted
{
    static void Main()
    {
        var text = Console.ReadLine().ToLower().Split(new char[]
            {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).Distinct().OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pyramidic
{
    static void Main()
    {
        List<string> lines = new List<string>();
        int n = int.Parse(Console.ReadLine());
        List<string> allPyramids = new List<string>();

        for (int i = 0; i < n; i++)
        {
            lines.Add(Console.ReadLine());
        }

        for (int i = 0; i < lines.Count; i++)
        {
            string line = lines[i];

            for (int j = 0; j < line.Length; j++)
            {
                char @char = line[j];
                string pyramid = FindPyramid(lines, @char, i);
                allPyramids.Add(pyramid);
            }
        }

        Console.WriteLine(allPyramids.OrderByDescending(p => p.Length).First());
    }

    static string FindPyramid(List<string> lines, char @char, int lineNumber)
    {
        int count = 3;
        string pyramid = String.Empty + @char + "\r\n";
        for (int j = lineNumber + 1; j < lines.Count; j++)
        {
            string charsToFind = new string(@char, count);

            if (lines[j].Contains(charsToFind))
            {
                pyramid += charsToFind + "\r\n";
                count += 2;
            }
            else
            {
                return pyramid;
            }
        }

        return pyramid;
    }
}


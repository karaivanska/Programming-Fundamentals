using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class BoomingCannon
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int numsToSkip = numbers[0];
        int numsToTake = numbers[1];

        string text = Console.ReadLine();
        string pattern = @"(?<=\\<<<)[A-Za-z]+";

        MatchCollection matches = Regex.Matches(text, pattern);
        List<string> matched = new List<string>();

        foreach (Match m in matches)
        {
            var currentWord = m.ToString().ToArray();
            var currentWords = string.Join("", currentWord.Skip(numsToSkip).Take(numsToTake));
            matched.Add(currentWords);
        }

        foreach (var word in matched)
        {
            if (IsMatchedContainOneWord(matched))
            {
                Console.WriteLine("{0}", word);
            }
            else
            {
                Console.Write(string.Join("/\\", matched));
                Console.WriteLine();
                break;
            }
            
        }
    }

    static bool IsMatchedContainOneWord(List<string> matched)
    {
        int count = 0;

        foreach (var m in matched)
        {
            count++;
        }

        if (count > 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}



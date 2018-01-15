using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CameraView
{
    static void Main()
    {
        string pattern = @"(?<=[A-Za-z0-9|\s+])([<]+)(?<word>[A-Za-z]+)";
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        string text = Console.ReadLine();

        int numsToSkip = numbers[0];
        int numsToGet = numbers[1];
        
        List<string> results = new List<string>();
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            string word = match.Groups["word"].ToString();
            word = string.Join("", word.Skip(numsToSkip).Take(numsToGet));
            results.Add(word);
        }

        Console.Write(string.Join(", ", results));
        
    }
}


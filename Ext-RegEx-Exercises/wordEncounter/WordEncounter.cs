using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WordEncounter
{
    static char letterToSearch;
    static int occurances;

    static void Main()
    {
        string input = Console.ReadLine();

        letterToSearch = input[0];
        occurances = input[1] - '0';

        input = Console.ReadLine();
        List<string> outputWords = new List<string>();

        while (input != "end")
        {
            if (IsValidSentence(input))
            {
                Regex wordsPattern = new Regex(@"\b\w+\b");
                MatchCollection matches = wordsPattern.Matches(input);

                foreach (Match m in matches)
                {
                    string word = m.Value;

                    if (IsValidWord(word))
                    {
                        outputWords.Add(word);

                    }
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", outputWords));
    }

    static bool IsValidWord(string word)
    {
        int index = word.IndexOf(letterToSearch);
        int count = 0;

        while (index != -1)
        {
            index = word.IndexOf(letterToSearch, index + 1);
            count++;
        }

        return (count >= occurances);
    }

    static bool IsValidSentence(string sentence)
    {
        Regex validSentencePattern = new Regex(@"^[A-Z].*[\.!\?]$");

        return validSentencePattern.IsMatch(sentence);
    }
}


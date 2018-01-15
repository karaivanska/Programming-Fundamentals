using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordsDict = new Dictionary<string, int>();

        var input = Console.ReadLine().ToLower().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < input.Count; i++)
        {
            string currentWord = input[i];
            if (!wordsDict.ContainsKey(currentWord))
            {
                wordsDict.Add(currentWord, 1);
            }
            else
            {
                wordsDict[currentWord]++;
            }
        }

        List<string> result = new List<string>();
        
        foreach (KeyValuePair<string, int> word in wordsDict)
        {
            
            if(word.Value %  2 != 0)
            result.Add(word.Key);
        }

        Console.Write(string.Join(", ", result));
        Console.WriteLine();
    }
}


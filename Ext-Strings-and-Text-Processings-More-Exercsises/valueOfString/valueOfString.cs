using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ValueOfString
{
    static void Main()
    {
        string textInput = Console.ReadLine();
        string actionType = Console.ReadLine();
        int sum = 0;

        ProcessText(textInput, actionType, ref sum);

        Console.WriteLine("The total sum is: {0}", sum);
    }

    static string ProcessText(string textInput, string actionType, ref int sum)
    {
        string result = string.Empty;

        if (actionType == "LOWERCASE")
        {
           result = GetAllLowerChars(textInput);
           SumCharacters(result, ref sum);
        }
        else if (actionType == "UPPERCASE")
        {
            result = GetAllUpperChars(textInput);
            SumCharacters(result, ref sum);
        }

        return result;
    }

    static string GetAllUpperChars(string textInput)
    {
        List<char> upperChars = new List<char>();
        for (int i = 0; i < textInput.Length; i++)
        {
            if (char.IsUpper(textInput[i]))
            {
                upperChars.Add(textInput[i]);
            }
        }

        return string.Join("", upperChars);
    }

    static void SumCharacters(string result, ref int sum)
    {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(result);

        for (int i = 0; i < asciiBytes.Length; i++)
        {
            sum += asciiBytes[i];
        }
    }

    static string GetAllLowerChars(string textInput)
    {
        List<char> lowerChars = new List<char>();
        for (int i = 0; i < textInput.Length; i++)
        {
            if (char.IsLower(textInput[i]))
            {
                lowerChars.Add(textInput[i]);
            }
        }

        return string.Join("", lowerChars);
    }
}


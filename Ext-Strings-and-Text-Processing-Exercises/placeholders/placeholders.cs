using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Placeholders
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            string text = input[0];
            string[] placeholders = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < placeholders.Length; i++)
            {
                string currentWord = placeholders[i];
                string placeholder = "{" + i + "}";

                text = text.Replace(placeholder, currentWord);

            }

            Console.WriteLine(text);

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}


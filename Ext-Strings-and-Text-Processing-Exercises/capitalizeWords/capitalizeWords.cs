using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CapitalizeWords
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputTokens =
                input.Split(
                    new string[]
                    { ",", ".", "/", "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+", "="," ", "<", ">" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputTokens.Length; ++i)
            {
                inputTokens[i] = ProcessInputTokens(inputTokens[i]);
            }

            Console.WriteLine(string.Join(", ", inputTokens));
            input = Console.ReadLine();
        }
    }

    private static string ProcessInputTokens(string inputTokens)
    {
        StringBuilder builder = new StringBuilder(inputTokens);
        builder[0] = char.ToUpper(builder[0]);
        for (int i = 1; i < builder.Length; i++)
        {
            builder[i] = char.ToLower(builder[i]);
        }

        return builder.ToString();
    }
}


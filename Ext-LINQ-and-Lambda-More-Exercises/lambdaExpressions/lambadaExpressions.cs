using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class lambadaExpressions
{
    static void Main()
    {
        var lambada = new Dictionary<string, Dictionary<string, string>>();

        string[] inputTokens =
            Console.ReadLine().Split(new string[] { "=>", " ", "." }, StringSplitOptions.RemoveEmptyEntries);

        while (inputTokens[0] != "lambada")
        {
            if (IsInputDance(inputTokens[0]))
            {
                var dance = lambada.Select(x => x.Value + "." + x.Value.Values);
                Console.WriteLine(string.Join(" ", dance));
            }
            else
            {
                string selectorName = inputTokens[0];
                string selectorObject = inputTokens[1];
                string property = inputTokens[2];

                if (!lambada.ContainsKey(selectorName))
                {
                    lambada.Add(selectorName, new Dictionary<string, string>());
                }

                if (!lambada[selectorName].ContainsKey(selectorObject))
                {
                    lambada[selectorName].Add(selectorObject, property);
                }
                else
                {
                    lambada[selectorName][selectorObject] = property;
                }
            }

            inputTokens = Console.ReadLine().Split(new string[] { "=>", " ", "." }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    static bool IsInputDance(string inputToken)
    {
        if (inputToken == "dance")
        {
            return true;
        }

        return false;
    }
}

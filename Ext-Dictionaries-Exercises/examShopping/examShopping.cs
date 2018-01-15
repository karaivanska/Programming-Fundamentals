using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class examShopping
{
    static void Main()
    {
        Dictionary<string, long> productsDict = new Dictionary<string, long>();
        var input = Console.ReadLine();

        while (input != "shopping time")
        {
            var commandArgs = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string product = commandArgs[1];
            long quantity = long.Parse(commandArgs[2]);

            if (!productsDict.ContainsKey(product))
            {
                productsDict.Add(product, quantity);
            }
            else
            {
                productsDict[product] += quantity;
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "exam time")
        {
            var commandArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string product = commandArgs[1];
            long quantity = long.Parse(commandArgs[2]);

            if (productsDict.ContainsKey(product))
            {
                if (productsDict[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else if (productsDict[product] < quantity)
                {
                    productsDict[product] = 0;
                }
                else
                {
                    productsDict[product] -= quantity;
                }
                
            }
            else
            {
                Console.WriteLine($"{product} doesn't exist");
            }

            input = Console.ReadLine();
        }


        foreach (KeyValuePair<string, long> product in productsDict)
        {
            if (product.Value != 0)
            {
                Console.WriteLine($"{product.Key} -> {product.Value}");
            }
        }
    }
}


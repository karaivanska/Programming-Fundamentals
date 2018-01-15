using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class shoppingSpree
{
    static void Main()
    {
        var productsData = new Dictionary<string, decimal>();

        decimal peshoBudget = decimal.Parse(Console.ReadLine());

        string[] inputTokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        while (!IsEnd(inputTokens[0]))
        {
            string productName = inputTokens[0];
            decimal productPrice = decimal.Parse(inputTokens[1]);

            if (!productsData.ContainsKey(productName))
            {
                productsData.Add(productName, productPrice);
            }
            else
            {
                if (productPrice < productsData[productName])
                {
                    productsData[productName] = productPrice;
                }
            }

            inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        decimal sumOfProducts = productsData.Values.Sum();

        if (IsPeshoBudgetBigger(peshoBudget, sumOfProducts))
        {
            foreach (var item in productsData.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
            {
                string product = item.Key;
                decimal price = item.Value;

                Console.WriteLine("{0} costs {1:F2}", product, price);
            }
        }
        else
        {
            Console.WriteLine("Need more money... Just buy banichka");
        }
    }

    static bool IsPeshoBudgetBigger(decimal peshoBudget, decimal sumOfProducts)
    {
        if (peshoBudget >= sumOfProducts)
        {
            return true;
        }

        return false;
    }

    static bool IsEnd(string inputToken)
    {
        return inputToken == "end";
    }
}


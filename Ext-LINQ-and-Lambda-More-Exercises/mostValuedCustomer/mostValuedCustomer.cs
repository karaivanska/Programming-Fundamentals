using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class mostValuedCustomer
{
    static Dictionary<string, double> storeProducts = new Dictionary<string, double>();
    static Dictionary<string, List<string>> customers = new Dictionary<string, List<string>>();
    static void Main()
    {
         storeProducts = new Dictionary<string, double>();
         customers = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "Shop is open") //check for "S/s/hop"
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string productName = tokens[0];
            double productPrice = double.Parse(tokens[1]);

            storeProducts.Add(productName, productPrice);

            input = Console.ReadLine();
        }

        string inputTokens = Console.ReadLine();

        while (inputTokens != "Print")
        {
            string[] tokens = inputTokens.Split(new string[] {":"," ",","}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (tokens[0] == "Discount")
            {
                var discountProducts = storeProducts
                    .OrderByDescending(pd => pd.Value)
                    .Take(3)
                    .Select(pd => new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));


                foreach (var discountProduct in discountProducts)
                {
                    storeProducts[discountProduct.Key] = discountProduct.Value;
                }
            }

            else
            {
                string customer = tokens[0];
                if (!customers.ContainsKey(customer))
                {
                    customers.Add(customer, new List<string>());
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    string boughtProduct = tokens[i];

                    if (storeProducts.ContainsKey(boughtProduct))
                    {
                        customers[customer].Add(boughtProduct);
                    }
                }
            }

            inputTokens = Console.ReadLine();
        }

        var topCustomer = customers.OrderByDescending(d => d.Value.Sum(product => storeProducts[product])).First();

        string name = topCustomer.Key;

        List<string> productsBought = topCustomer.Value;
        Console.WriteLine("Biggest spender: {0}", name);
        Console.WriteLine("^Products bought:");

        double total = productsBought.Sum(p => storeProducts[p]);
        var orderedProducts = productsBought.Distinct().OrderByDescending(p => storeProducts[p]);

        foreach (var product in orderedProducts)
        {
            Console.WriteLine("^^^{0}: {1:F2}", product, storeProducts[product]);
        }

        Console.WriteLine("Total: {0:F2}", total);
    }
}


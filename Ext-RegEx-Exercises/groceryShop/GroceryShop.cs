using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class GroceryShop
{
    static void Main()
    {
        var groceryData = new Dictionary<string, double>();
        string text = Console.ReadLine();
        while (text != "bill")
        {
            //string pattern = @"\b[A-Z][a-z]+:\d{2}\.\d{2}\b";
            string pattern = @"^[A-Z][a-z]+:\d{2}\.\d{2}$";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string products = match.ToString();
                string[] productsInfo = products.Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);

                string productName = productsInfo[0];
                double productPrice = double.Parse(productsInfo[1]);

                if (!groceryData.ContainsKey(productName))
                {
                    groceryData[productName] = productPrice;
                }
                else
                {
                    groceryData[productName] = productPrice;
                }
            }

            text = Console.ReadLine();
        }

        foreach (var kvp in groceryData.OrderByDescending(x => x.Value))
        {
            string product = kvp.Key;
            double price = kvp.Value;
            Console.WriteLine($"{product} costs {price:F2}");
        }
    }
}


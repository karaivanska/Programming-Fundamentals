using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class orderedBankingSystem
{
    static void Main()
    {
        var bankData = new Dictionary<string, Dictionary<string, decimal>>();

        var input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputTokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

            string nameOfBank = inputTokens[0];
            string bankAccount = inputTokens[1];
            decimal balance = decimal.Parse(inputTokens[2]);

            if (!bankData.ContainsKey(nameOfBank))
            {
                bankData.Add(nameOfBank, new Dictionary<string, decimal>());
            }

            if (!bankData[nameOfBank].ContainsKey(bankAccount))
            {
                bankData[nameOfBank].Add(bankAccount, balance);
            }
            else
            {
                bankData[nameOfBank][bankAccount] += balance;
            }

            input = Console.ReadLine();
        }

        foreach (var item in bankData.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Max()))
        {
            string bank = item.Key;
            Dictionary<string, decimal> accountsData = item.Value;

            foreach (var kvp in accountsData.OrderByDescending(x => x.Value))
            {
                string account = kvp.Key;
                decimal balance = kvp.Value;
                Console.WriteLine("{0} -> {1} ({2})", account, balance, bank);
            }
        }
    }
}


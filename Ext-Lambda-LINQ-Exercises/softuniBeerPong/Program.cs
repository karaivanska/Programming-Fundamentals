using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
         var tournament = new Dictionary<string, Dictionary<string, int>>();
        string[] inputTokens = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        while (!IsStop(inputTokens[0]))
        {
            string playerName = inputTokens[0];
            string teamName = inputTokens[1];
            int playerScores = int.Parse(inputTokens[2]);

            if (!tournament.ContainsKey(teamName))
            {
                tournament.Add(teamName, new Dictionary<string, int>());
                tournament[teamName].Add(playerName, playerScores);
            }
            else
            {
                if (tournament[teamName].Count < 3) 
                {
                    tournament[teamName].Add(playerName, playerScores);
                }
            }

            inputTokens = Console.ReadLine().Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        int countTeams = 0;

        foreach (var item in tournament.Where(x => x.Value.Keys.Count == 3).OrderByDescending(x => x.Value.Values.Sum()))
        {
            string team = item.Key;
            Dictionary<string, int> teamData = item.Value;
            countTeams++;

            Console.WriteLine("{0}. {1}; Players:", countTeams, team);

            foreach (var kvp in teamData.OrderByDescending(x => x.Value))
            {
                
                Console.WriteLine("###{0}: {1}", kvp.Key, kvp.Value );
            }
        }
    }

    static bool IsStop(string inputToken)
    {
        return inputToken == "stop";  
    }
}


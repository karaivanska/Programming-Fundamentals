using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class userLogins
{
    static void Main()
    {
        Dictionary<string, string> userLogins = new Dictionary<string, string>();
        List<string> userResults = new List<string>();
        List<string> loginMessage = new List<string>();

        var input = Console.ReadLine();
        string username = String.Empty;
        string password = String.Empty;
        int count = 0;

        while (input != "login")
        {
            var commandArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            username = commandArgs[0];
            password = commandArgs[1];

            if (!userLogins.ContainsKey(username))
            {
                userLogins.Add(username, password);
            }
            else
            {
                userLogins[username] = password;
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "end")
        {
            var commandArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            username = commandArgs[0];
            password = commandArgs[1];
           
            if (userLogins.ContainsKey(username))
            {
                if (userLogins[username].Equals(password))
                {
                    userResults.Add(username);
                    loginMessage.Add("logged in successfully");
                }
                else
                {
                    userResults.Add(username);
                    loginMessage.Add("login failed");
                    count++;
                }
            }
            else
            {
                userResults.Add(username);
                loginMessage.Add("login failed");
                count++;
            }

            input = Console.ReadLine();
        }

        for (int i = 0; i < userResults.Count; i++)
        {
            for (int j = 0; j < loginMessage.Count; j++)
            {
                if (i == j)
                {
                    Console.WriteLine($"{userResults[i]}: {loginMessage[j]}");
                }
            }
        }

        Console.WriteLine($"unsuccessful login attempts: {count}");
    }
}


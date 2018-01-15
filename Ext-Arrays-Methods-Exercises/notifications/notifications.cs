using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class notifications
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string command = Console.ReadLine();

            if (command == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();

                ShowSucess(operation, message);
            }
            else if (command == "error")
            {
                string operation = Console.ReadLine();
                int message = int.Parse(Console.ReadLine());

                ShowError(operation, message);
            }
            else
            {
                continue;
            }
        }
    }

    private static void ShowError(string operation, int message)
    {
        Console.WriteLine($"Error: Failed to execute {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Error Code: {message}.");

        if (message > 0)
        {
            Console.WriteLine("Reason: Invalid Client Data.");
        }
        else
        {
            Console.WriteLine("Reason: Internal System Failure.");
        }
    }

    private static void ShowSucess(string operation, string message)
    {
        Console.WriteLine($"Successfully executed {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Message: {message}.");
    }
}


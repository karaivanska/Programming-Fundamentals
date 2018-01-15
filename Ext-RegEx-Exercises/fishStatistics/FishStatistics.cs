using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class FishStatistics
{
    static int tailLength;
    static int bodyLength;
    static string status;
    static string tailType;
    static string bodyType;

    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<tail>[>+|<+]+)(?<body>[(]+)(?<status>['|\-|x])>+";

        MatchCollection matchees = Regex.Matches(input, pattern);
        int countFish = 0;

        if (IsMatcheesEmpty(matchees))
        {
            Console.WriteLine("No fish found.");
        }
        else
        {
            foreach (Match match in matchees)
            {
                ProcessMatch(match);
                countFish++;
                Console.WriteLine($"Fish {countFish}: {match}");
                if (tailLength == 0)
                {
                    Console.WriteLine($"  Tail type: {tailType}");
                }
                else
                {
                    Console.WriteLine($"  Tail type: {tailType} ({tailLength} cm)");
                }
                Console.WriteLine($"  Body type: {bodyType} ({bodyLength} cm)");
                Console.WriteLine($"  Status: {status}");
            }
        }
        
    }

    static bool IsMatcheesEmpty(MatchCollection matchees)
    {
        if (matchees.Count == 0)
        {
            return true;
        }

        return false;
    }

    static void ProcessMatch(Match match)
    {
        string tail = match.Groups["tail"].Value;
        CalculateTailLength(tail);
        string body = match.Groups["body"].Value;
        CalculateBodyLength(body);
        string statusType = match.Groups["status"].Value;
        TypeOfStatus(statusType);
    }

    static void BodyType(int numOfSymbols)
    {
        bodyType = "";
        if (numOfSymbols > 10)
        {
            bodyType = "Long";
        }
        else if (numOfSymbols > 5)
        {
            bodyType = "Medium";
        }
        else
        {
            bodyType = "Short";
        }
    }

    static void TailType(int countTailSymbol)
    {
        tailType = "";
        if (countTailSymbol  > 0 && countTailSymbol <= 1)
        {
            tailType = "Short";
        }
        else if (countTailSymbol > 5)
        {
            tailType = "Long";
        }
        else if (countTailSymbol > 1)
        {
            tailType = "Medium";
        }
        else
        {
            tailType = "None";
        }
    }

    static void TypeOfStatus(string statusType)
    {
        status = "";
        char symbol = statusType[0];
        if (symbol.Equals('\''))
        {
            status = "Awake";
        }
        else if (symbol.Equals('-'))
        {
            status = "Asleep";
        }
        else if (symbol.Equals('x'))
        {
            status = "Dead";
        }
    }

    static void CalculateBodyLength(string body)
    {
        bodyLength = 0;
        int numOfSymbols = body.Count();
        bodyLength = 2 * numOfSymbols;
        BodyType(numOfSymbols);
    }

    static void CalculateTailLength(string tail)
    {
        int countTailSymbol = 0;

        foreach (var m in tail)
        {
            if (m.Equals('>'))
            {
                countTailSymbol++;
            }
        }
        tailLength = 0;
        int sum = countTailSymbol * 2;

        if (sum != 0)
        {
            tailLength = countTailSymbol * 2;
        }

        TailType(countTailSymbol);
    }
}


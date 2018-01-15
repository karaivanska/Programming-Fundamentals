using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class HappinessIndex
{
    static double countHappyFaces = 0;
    static double countSadFaces = 0;
    static double happinesIndex = 0;
    static string faceEmotion = "";

    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<happy>([*|c|[|(][:|;])|([:|;][)|\]|}|*|D|]))|(?<sad>([:|;][ (|[|{|c])|([D|)|\]][:|;]))";
        

        MatchCollection matches = Regex.Matches(input, pattern);
        
        foreach (Match match in matches)
        {
            string happyFace = match.Groups["happy"].Value;
            CalcHappyFaces(happyFace);
            string sadFace = match.Groups["sad"].Value;
            CalcSadFaces(sadFace);
        }

        CalculateHappinessIndex();
        DefineFaceEmotion();

        Console.WriteLine($"Happiness index: {happinesIndex:F2} {faceEmotion}");
        Console.WriteLine($"[Happy count: {countHappyFaces}, Sad count: {countSadFaces}]");
    }

    static void DefineFaceEmotion()
    {
        if (happinesIndex >= 2)
        {
            faceEmotion = ":D";
        }
        else if (happinesIndex > 1)
        {
            faceEmotion = ":)";
        }
        else if (happinesIndex == 1)
        {
            faceEmotion = ":|";
        }
        else if (happinesIndex < 1)
        {
            faceEmotion = ":(";
        }
    }

    static void CalculateHappinessIndex()
    {
        happinesIndex = (countHappyFaces / countSadFaces);
    }

    static void CalcSadFaces(string sadFace)
    {
        switch (sadFace)
        {
            case ":(": countSadFaces++; break;
            case "D:": countSadFaces++; break;
            case ";(": countSadFaces++; break;
            case ":[": countSadFaces++; break;
            case ";[": countSadFaces++; break;
            case ":{": countSadFaces++; break;
            case ";{": countSadFaces++; break;
            case ":c": countSadFaces++; break;
            case "]:": countSadFaces++; break;
            case "];": countSadFaces++; break;
            case "):": countSadFaces++; break;
        }
    }

    static void CalcHappyFaces(string happyFace)
    {
        switch (happyFace)
        {
            case ":)": countHappyFaces++; break;
            case ":D": countHappyFaces++; break;
            case ";)": countHappyFaces++; break;
            case ":*": countHappyFaces++; break;
            case ":]": countHappyFaces++; break;
            case ";]": countHappyFaces++; break;
            case ":}": countHappyFaces++; break;
            case ";}": countHappyFaces++; break;
            case "*:": countHappyFaces++; break;
            case "c:": countHappyFaces++; break;
            case "[:": countHappyFaces++; break;
            case "[;": countHappyFaces++; break;
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string cypherStr = "", currString, prevString = "";
        string concatMode = "NormalMode";

        while (num > 0)
        {
            currString = Console.ReadLine();

            if (prevString == currString)
            {
                cypherStr = String.Empty;

                if (prevString != "spin")
                {
                    num--;
                    continue;
                }

            }

            if (currString != "spin")
            {
                num--;
            }
            else
            {
                if (concatMode == "SpinMode")
                {
                    concatMode = "NormalMode";
                }
                else
                {
                    concatMode = "SpinMode";
                }

                prevString = currString;
                continue;
            }

            switch (concatMode)
            {
                case "NormalMode": cypherStr = cypherStr + currString;
                    break;

                case "SpinMode": cypherStr = currString + cypherStr;
                    break;
            }

            prevString = currString;
        }

        Console.WriteLine(cypherStr);
    }
}



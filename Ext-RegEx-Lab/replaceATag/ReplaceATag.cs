﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceATag
{
    static void Main()
    {
        var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

        var input = Console.ReadLine();
        while (input != "end")
        {
            string replacement = @"[URL href=$1]$2[/URL]";

            string replaced = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(replaced);

            input = Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class numbersToWords
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Letterize(n);
    }

    private static void Letterize(long n)
    {
        string result = String.Empty;

        string[] hundreds =
        {
            "one-hundred", "two-hundred", "three-hundred", "four-hundred", "five-hundred",
            "six-hundred", "seven-hundred", "eight-hundred", "nine-hundred"
        };

        string[] teens =
        {
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen"
        };

        string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string[] ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());

            if (number > 999)
            {
                result = "too large";
            }
            else if (number < -999)
            {
                result = "too small";
            }

            if (number <= -100 && number >= -999)
            {
                result = "minus" + " ";
                number = Math.Abs(number);
            }

            if (number >= 100 && number < 1000)
            {
                if (number % 100 == 0)
                {
                    result += (hundreds[(number / 100) - 1]);
                }
                else if (number % 10 == 0 && number % 100 != 0)
                {
                    result += ($"{hundreds[(number / 100) - 1]} and {tens[number % 100 / 10 - 1]}");
                }
                else if (number % 10 != 0)
                {
                    if (number / 10 % 10 < 2 && number / 10 % 10 > 0)
                    {
                        result += ($"{hundreds[(number / 100) - 1]} and {teens[(number % 10 - 1)]}");
                    }
                    else if (number / 10 % 10 == 0)
                    {
                        result += ($"{hundreds[(number / 100) - 1]} and {ones[(number % 10) - 1]}");
                    }
                    else
                    {
                        result +=
                        ($"{hundreds[(number / 100) - 1]} and {tens[(number % 100 / 10 - 1)]} {ones[(number % 10 - 1)]}"
                        );
                    }
                }
            }

            Console.WriteLine(result);
            result = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int lightYear = int.Parse(Console.ReadLine());

        decimal lightWeeksInOneYear = (decimal)(lightYear * 365.25);
        decimal lightDaysInWeek = lightWeeksInOneYear / 7;
        // double lightDays = lightWeeksInOneYear * 365.25;


    }
}


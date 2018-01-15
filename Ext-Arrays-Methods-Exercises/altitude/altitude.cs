using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class altitude
{
    static void Main()
    {
        var commandArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        double altitude = double.Parse(commandArgs[0]);
        double result = 0;

        for (int i = 1; i < commandArgs.Length; i ++)
        {
            if (altitude > 0)
            {
                if (i % 2 != 0 && commandArgs[i] == "up")
                {
                    result = altitude + Convert.ToUInt64(commandArgs[i + 1]);
                    altitude = result;
                }
                else if (i % 2 != 0 && commandArgs[i] == "down")
                {
                    result = altitude - Convert.ToUInt64(commandArgs[i + 1]);
                    altitude = result;
                }
            }
            else 
            {
                Console.WriteLine("crashed");
                return;
            }
        }

        Console.WriteLine($"got through safely. current altitude: {result}m");
    }
}


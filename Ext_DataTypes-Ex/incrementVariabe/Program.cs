using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incrementVariabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int result = 0;

            while (n >= byte.MaxValue)
            {
                counter++;
                result = Math.Abs(byte.MaxValue - n) - 1;
                n = result;
            }

            if (counter > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine($"Overflowed {counter} times");
            }
            else
            {
                Console.WriteLine(n);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class sumMinMaxAvarage
{
    static void Main()
    {
        List<double> numbersCollection = new List<double>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbersCollection.Add(number);
        }

        Console.WriteLine("Sum = {0}", numbersCollection.Sum());
        Console.WriteLine("Min = {0}", numbersCollection.Min());
        Console.WriteLine("Max = {0}", numbersCollection.Max());
        Console.WriteLine("Average = {0}", numbersCollection.Average());
    }
}


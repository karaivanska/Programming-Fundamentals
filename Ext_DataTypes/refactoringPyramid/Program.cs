using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        double volume = 0;
        volume = (length * width * height) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}


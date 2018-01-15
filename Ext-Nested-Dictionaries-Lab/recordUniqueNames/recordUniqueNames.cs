using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class recordUniqueNames
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();

            names.Add(name);

        }
        
        foreach (var name in names)
        {
            Console.WriteLine(string.Join(" ", name));
        }
    }
}


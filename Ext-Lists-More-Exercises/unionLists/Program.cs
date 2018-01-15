using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var primal = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(ulong.Parse)
            .ToList();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) 
        {
            var currentSequence = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(ulong.Parse).ToList();

            CheckForContainedNumber(primal, currentSequence);
        }

        primal.Sort();
        Console.WriteLine(string.Join(" ", primal));
    }

    private static void CheckForContainedNumber(List<ulong> primal, List<ulong> currentSequence)
    {
        foreach (var number in currentSequence)
        {
            if (!primal.Contains(number))
            {
                primal.Add(number);
            }
            else
            {
                primal.RemoveAll(x => x == number);
            }
        }
    }
}

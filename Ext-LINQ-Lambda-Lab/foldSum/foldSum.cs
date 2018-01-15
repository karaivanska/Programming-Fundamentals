using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class foldSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        List<int> left = numbers.Take(k).Reverse().ToList();

        List<int> right = numbers.Reverse().Take(k).ToList();

        int[] downArr = numbers.Skip(k).Take(2 * k).ToArray();
        int[] upperArr = left.Concat(right).ToArray();

        for (int i = 0; i < downArr.Length; i++)
        {
            downArr[i] += upperArr[i];
        }

        Console.WriteLine(string.Join(" ", downArr));
    }
}


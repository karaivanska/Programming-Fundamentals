using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        List<int> result = new List<int>();

        InsertionSort(numbers, result);

        Console.WriteLine(String.Join(" ", result));
    }

    private static List<int> InsertionSort(List<int> numbers, List<int> result)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            int elementToInsert = numbers[i];
            bool hasInserted = false;

            for (int j = 0; j < result.Count; j++)
            {
                int currentElement = result[j];

                if (elementToInsert < currentElement)
                {
                    result.Insert(j, elementToInsert);
                    hasInserted = true;
                    break;
                }
            }

            if (!hasInserted)
            {
                result.Add(elementToInsert);
            }
        }

        return result;
    }
}


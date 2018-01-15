using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToList();

        List<string> notes = new List<string>();
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();
        double sumOfNaturals = 0;
        double sumOfSharps = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            switch (numbers[i])
            {
                case 261.63: notes.Add("C");
                    naturals.Add("C");
                    sumOfNaturals += numbers[i];
                    break;
                case 277.18: notes.Add("C#"); sharps.Add("C#");
                    sumOfSharps += numbers[i];
                    break;
                case 293.66: notes.Add("D"); naturals.Add("D"); sumOfNaturals += numbers[i];
                    break;
                case 311.13: notes.Add("D#"); sharps.Add("D#");
                    sumOfSharps += numbers[i];
                    break;
                case 329.63: notes.Add("E"); naturals.Add("E");
                    sumOfNaturals += numbers[i];
                    break;
                case 349.23: notes.Add("F"); naturals.Add("F");
                    sumOfNaturals += numbers[i];
                    break;
                case 369.99: notes.Add("F#"); sharps.Add("F#");
                    sumOfSharps += numbers[i];
                    break;
                case 392.00: notes.Add("G"); naturals.Add("G");
                    sumOfNaturals += numbers[i];
                    break;
                case 415.30: notes.Add("G#"); sharps.Add("G#");
                    sumOfSharps += numbers[i];
                    break;
                case 440.00: notes.Add("A"); naturals.Add("A");
                    sumOfNaturals += numbers[i];
                    break;
                case 466.16: notes.Add("A#"); sharps.Add("A#");
                    sumOfSharps += numbers[i];
                    break;
                case 493.88: notes.Add("B"); naturals.Add("B");
                    sumOfNaturals += numbers[i];
                    break;
            }
        }

        Console.WriteLine($"Notes: {string.Join(" ", notes)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
        Console.WriteLine($"Naturals sum: {sumOfNaturals}");
        Console.WriteLine($"Sharps sum: {sumOfSharps}");
    }
}


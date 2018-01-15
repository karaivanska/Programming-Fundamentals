using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class wardrobe
{
    static void Main()
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string color = input[0];
            var clothes = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }

            foreach (var clothe in clothes)
            {

                if (!wardrobe[color].ContainsKey(clothe))
                {
                    wardrobe[color].Add(clothe, 0);
                }

                wardrobe[color][clothe]++;

            }
        }

        string[] inputSearch = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string colorSearch = inputSearch[0];
        string clothesSearch = inputSearch[1];

        Console.WriteLine();

        foreach (var item in wardrobe)
        {
            string color = item.Key;
            Dictionary<string, int> clothes = item.Value;


            Console.WriteLine("{0} clothes:", color);

            foreach (var eachCloth in clothes)
            {
                string cloth = eachCloth.Key;
                int count = eachCloth.Value;

                Console.Write("* {0} - {1}",  cloth, count);

                if (cloth == clothesSearch && color == colorSearch)
                {
                    Console.Write(" (found!)");
                }

                Console.WriteLine();
            }
        }
    }
}


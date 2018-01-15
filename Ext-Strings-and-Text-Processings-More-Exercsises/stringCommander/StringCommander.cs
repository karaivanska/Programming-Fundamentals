using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringCommander
{
    static void Main()
    {
        string text = Console.ReadLine();

        while (text != "end")
        {
            string[] args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (args.Length > 2)
            {
                if (command == "Delete")
                {
                    int startIndex = int.Parse(args[1]);
                    int endIndex = int.Parse(args[2]);
                    text = text.Remove(startIndex, endIndex + 1);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(args[1]);
                    string str = args[2];
                    text = text.Insert(index, str);
                }
            }
            else
            {
                if (command == "Left")
                {
                    int positionsToMove = int.Parse(args[1]);
                    int count = 0;

                    while (count < positionsToMove)
                    {
                        ShiftElementsToLeft(ref count, positionsToMove, ref text);
                    }

                }
                else if (command == "Right")
                {
                    int countRight = int.Parse(args[1]);
                    int positionsToMove = int.Parse(args[1]);
                    ShiftElementsToRight(countRight, positionsToMove, text);
                }
            }
        }
    }

   static void ShiftElementsToRight(int countRight, int positionsToMove, string text)
    {
        throw new NotImplementedException();
    }

    static string ShiftElementsToLeft(ref int count, int positionsToMove, ref string text)
    {
        count++;
        if (positionsToMove > text.Length)
        {
            positionsToMove = positionsToMove % text.Length;
        }

        StringBuilder builder = new StringBuilder(text.Substring(positionsToMove, (text.Length - positionsToMove)));
        builder.Append(text.Substring(0, positionsToMove));
        return text = builder.ToString();
    }
}


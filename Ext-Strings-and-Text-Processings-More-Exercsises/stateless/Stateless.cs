using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Stateless
{
    static void Main()
    {
        string firstInput = Console.ReadLine();

        while (firstInput != "collapse")
        {
            string secondInput = Console.ReadLine();

            while (secondInput.Length > 0)
            {
                bool isContain = firstInput.Contains(secondInput);

                if (isContain)
                {
                    firstInput = firstInput.Replace(secondInput, "");
                    isContain = false;
                }
                else
                {
                    secondInput = secondInput.Remove(0, 1);

                    if (secondInput.Length > 0)
                    {
                        secondInput = secondInput.Remove(secondInput.Length - 1, 1);
                    }
                }
            }

            if (firstInput.Length > 0)
            {
                Console.WriteLine(firstInput.Trim());
            }
            else
            {
                Console.WriteLine("(void)");
            }

            firstInput = Console.ReadLine();
        }
    }
}


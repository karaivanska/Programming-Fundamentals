using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int result = 0;

        if (symbol == '+')
        {
            result = firstNum + secondNum;
            Console.WriteLine($"{firstNum} {symbol} {secondNum} = {result}");
        }
        else if (symbol == '-')
        {
            result = firstNum - secondNum;
            Console.WriteLine($"{firstNum} {symbol} {secondNum} = {result}");
        }
        else if (symbol == '*')
        {
            result = firstNum * secondNum;
            Console.WriteLine($"{firstNum} {symbol} {secondNum} = {result}");
        }
        else if (symbol == '/')
        {
            result = firstNum / secondNum;
            Console.WriteLine($"{firstNum} {symbol} {secondNum} = {result}");
        }
    }
}

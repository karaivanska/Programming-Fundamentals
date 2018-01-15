using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        ulong firstNum = ulong.Parse(Console.ReadLine());
        ulong secondNum = ulong.Parse(Console.ReadLine());

        string firstNumber = "";
        string secNumber = "";

        ulong secondResult = 0;
        ulong biggerNum = Math.Max(firstNum, secondNum);
        ulong smallerNum = Math.Min(firstNum, secondNum);

        ulong overFlow = 0;

        if (biggerNum > smallerNum)
        {
            if (biggerNum >= byte.MinValue && biggerNum <= byte.MaxValue)
            {
                firstNumber += "byte";

            }
            else if (biggerNum >= ushort.MinValue && biggerNum <= ushort.MaxValue)
            {
                firstNumber += "ushort";
            }
            else if (biggerNum >= uint.MinValue && biggerNum <= uint.MaxValue)
            {
                firstNumber += "uint";
            }
            else if (biggerNum >= ulong.MinValue && biggerNum <= ulong.MaxValue)
            {
                firstNumber += "ulong";
            }
        }

        if (smallerNum >= byte.MinValue && smallerNum <= byte.MaxValue)
        {
            secNumber += "byte";
            secondResult += byte.MaxValue;
        }
        else if (smallerNum >= ushort.MinValue && smallerNum <= ushort.MaxValue)
        {
            secNumber += "ushort";
            secondResult += ushort.MaxValue;
        }
        else if (smallerNum >= uint.MinValue && smallerNum <= uint.MaxValue)
        {
            secNumber += "uint";
            secondResult += uint.MaxValue;
        }
        else if (smallerNum >= ulong.MinValue && smallerNum <= ulong.MaxValue)
        {
            secNumber += "ulong";
            secondResult += ulong.MaxValue;
        }

        Console.WriteLine($"bigger type: {firstNumber}");
        Console.WriteLine($"smaller type: {secNumber}");
        Console.WriteLine($"{biggerNum} can overflow {secNumber} {Math.Round((double)biggerNum / secondResult)} times");

    }
}


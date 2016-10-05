using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            GetMax(firstNumber,secondNumber);
            if (thirdNumber > GetMax(firstNumber, secondNumber))
            {
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
        }

        private static int GetMax(int firstNumber,int secondNumber)
        {
            int MaxValue = 0;
            if (firstNumber>secondNumber)
            {
                MaxValue = firstNumber;
            }
            else
            {
                MaxValue = secondNumber;
            }
            return MaxValue;
        }
    }
}

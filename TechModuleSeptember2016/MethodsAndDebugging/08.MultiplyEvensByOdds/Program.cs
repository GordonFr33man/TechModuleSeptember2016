using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetMultipleOfEvensAndOdds(number);
            int result = Math.Abs(GetMultipleOfEvensAndOdds(number));
            Console.WriteLine(result);

        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
             int sumOdds = GetSumOfOddDigits(number);
            return Math.Abs(sumEvens * sumOdds);
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = Math.Abs(number % 10);
                if (lastDigit %2 != 0)
                {
                   Math.Abs( sum += lastDigit);
                }
               Math.Abs( number /= 10);
            }
            return Math.Abs(sum);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = Math.Abs(number % 10);
                if (lastDigit % 2 == 0)
                {
                    Math.Abs(sum += lastDigit);
                }
                Math.Abs(number /= 10);
            }
            return Math.Abs(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
            IsPrime(number);
        }

        private static bool IsPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

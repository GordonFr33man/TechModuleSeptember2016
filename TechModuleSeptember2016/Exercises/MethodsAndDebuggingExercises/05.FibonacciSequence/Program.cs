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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));

        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
               

            }
            return c;
        }
    }
}

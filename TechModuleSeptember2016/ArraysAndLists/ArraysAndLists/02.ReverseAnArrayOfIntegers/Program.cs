using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

            }
            for (int i = number.Length-1; i >= 0; i--)
            {
                Console.WriteLine(number[i]);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.drawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', n * 2));
           
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write("\\/");
                 
                }
                Console.WriteLine('-');
            }
            Console.WriteLine(new string('-', n * 2));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.greaterThanTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type=="int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                int max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);

            }
            else if (type=="char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                char max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
            else if (type=="string")
            {  
               string firstInput = Console.ReadLine();
               string secondInput = Console.ReadLine();
               string max = GetMax(firstInput, secondInput);
                Console.WriteLine(max);
            }
         
        }

        private static string GetMax(string firstInput,string secondInput)
        {
            if (firstInput.CompareTo(secondInput)>=0)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }

        private static char GetMax(char firstInput, char secondInput)
        {
            if (firstInput > secondInput)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }

        private static int GetMax(int firstInput, int secondInput)
        {
            if (firstInput >= secondInput)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }

        }
    }
}

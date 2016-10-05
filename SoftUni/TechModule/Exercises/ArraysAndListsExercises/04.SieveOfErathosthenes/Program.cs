using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SieveОfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayInput = new int[n + 1];
            bool[] checkNumbers = new bool[n + 1];

            string primeNumbers = null;

            for (int i = 0; i <= n; i++)
            {
                arrayInput[i] = i;
                checkNumbers[i] = true;
            }

            primeNumbers = SieveOfErat(arrayInput, checkNumbers, primeNumbers);

            Console.WriteLine(primeNumbers.Trim());
        }

        private static string SieveOfErat(int[] arrInput, bool[] checkNums, string primeNums)
        {
            checkNums[0] = false;
            checkNums[1] = false;

            for (int i = 0; i < arrInput.Length; i++)
            {
                if (checkNums[i])
                {
                    primeNums += $"{arrInput[i]} ";

                    for (int j = i + 1; j < arrInput.Length; j++)
                    {
                        if (arrInput[j] % i == 0 && checkNums[j] == true)
                        {
                            checkNums[j] = false;
                        }
                    }
                }
            }

            return primeNums;
        }
    }
}
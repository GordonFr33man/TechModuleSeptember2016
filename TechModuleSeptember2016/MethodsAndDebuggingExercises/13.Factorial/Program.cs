using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger integer = 1;
        Factorial(integer,number);
      
    }

    private static void Factorial(BigInteger integer,double number)
    {
        for (int i = 1; i <= number; i++)
        {
            integer *= i;
        }
        Console.WriteLine(integer);
    }
}
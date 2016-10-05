using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        BigInteger integer = 1;
        Factorial(integer, i);
        Console.WriteLine(numTrailingBinaryZeros(i));
    }
    public static int numTrailingBinaryZeros(int integer)
{
    int mask = 1;
    for (int k = 0; k < 32; k++, mask <<= 1)
        if ((integer & mask) != 0)
            return k;

    return 32;
}
    private static void Factorial(BigInteger integer, double i)
    {
        for (int j = 1; j <= i; j++)
        {
            integer *= j;
        }
        Console.WriteLine(integer);
    }
}
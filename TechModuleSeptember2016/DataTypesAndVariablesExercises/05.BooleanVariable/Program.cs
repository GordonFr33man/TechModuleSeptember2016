using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();

        if (input == "true")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
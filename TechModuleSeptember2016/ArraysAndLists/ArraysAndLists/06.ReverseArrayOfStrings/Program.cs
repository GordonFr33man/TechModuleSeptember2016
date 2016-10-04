namespace _06.ReverseArray
{
    using System;
    using System.Linq;

    public class ReverseArrayMain
    {
        public static void Main(string[] args)
        {
            string[] chars = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", chars.Reverse()));
        }
    }
}
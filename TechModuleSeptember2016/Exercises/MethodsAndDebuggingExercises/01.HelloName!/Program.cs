using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(HelloName(name));
        }

        private static string HelloName(string name)
        {
            return $"Hello, {name}!";
        } 
    }
}

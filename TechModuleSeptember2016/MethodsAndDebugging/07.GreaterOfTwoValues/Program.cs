using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type= Console.ReadLine();
            if (type == "char")
            {
                PrintMaxChar();
            }
            else if (type=="int")
            {

            }
            else if (type=="string")
            {

            }

        }

        private static char PrintMaxChar(char firstChar,char secondChar)
        {
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];
            if (firstChar.CompareTo(secondChar) > 0)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}

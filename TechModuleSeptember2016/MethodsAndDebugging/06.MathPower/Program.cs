using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
           double firstNum =double.Parse(Console.ReadLine());
           double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine( RaiseToPower(firstNum,secondNum));
        }

        private static double RaiseToPower(double firstNum,double secondNum)
        {
            double result = Math.Pow(firstNum, secondNum);
          
            return result;
        }
    }
}

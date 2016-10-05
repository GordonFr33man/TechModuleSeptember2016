using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestRangePoints(x1, y1, x2, y2);
        }

        private static void PrintClosestRangePoints(double x1, double y1, double x2, double y2)
        {
            double DistanceFirstPointToCenter = Math.Sqrt(x1 * x1 + y1 * y1);
            double DistanceSecondPointToCenter = Math.Sqrt(x2 * x2 + y2 * y2);
            if (DistanceFirstPointToCenter < DistanceSecondPointToCenter)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

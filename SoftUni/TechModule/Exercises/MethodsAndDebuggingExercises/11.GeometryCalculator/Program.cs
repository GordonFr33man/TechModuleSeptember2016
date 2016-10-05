using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Triangle(side, height):f2}");
            }
            else if (figureType=="square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{Square(side):f2}");

            }
            else if (figureType=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
               
                Console.WriteLine($"{Circle(radius):f2}");
            }
            else if (figureType=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height= double.Parse(Console.ReadLine());
                Console.WriteLine($"{Rectangle(width, height):f2}");
            }
            
        }

        private static double Rectangle(double width,double height)
        {
            double area = width * height;
            return area;
        }

        private static double Circle(double radius)
        {
            double area = Math.PI * (radius*radius);
            return area;
        }

        private static double Square(double side)
        {
            double area = side * side;
            return area;
        }

        private static double Triangle(double side,double height)
        {
            double area = (side * height) / 2;
            return area;
        }
    }
}

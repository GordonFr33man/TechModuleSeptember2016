using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            CubeSurface(a);
            CubeVolume(a);
            CubeFaceDiagonals(a);
            CubeSpaceDiagonals(a);
            if (type == "face")
            {
                Console.WriteLine($"{CubeFaceDiagonals(a):f2}");
            }
            else if (type=="space")
            {
                Console.WriteLine($"{CubeSpaceDiagonals(a):f2}");
            }
            else if (type=="volume")
            {
                Console.WriteLine($"{CubeVolume(a):f2}");
            }
            else
            {
                Console.WriteLine($"{CubeSurface(a):f2}");
            }
        }

        private static double CubeSpaceDiagonals(double a)
        {
            double spaceDiagonal = Math.Sqrt(3 * (a * a));
            return spaceDiagonal;
        }

        private static double CubeFaceDiagonals(double a)
        {

            double faceDiagonals = Math.Sqrt(2 * (a * a));
            return faceDiagonals;

        }

        private static double CubeVolume(double a)
        {
            double cubeVolume = a * a * a;
            return cubeVolume;
        }

        private static double CubeSurface(double a)
        {
            double surface = (a * a) * 6;
            return surface;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            for (int i = 0; i < day-(day-1); i++)
            {
                if (day >= 1 && day <= 7)
                {
                    Console.WriteLine(days[day - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid Day!");
                }
            }
        }
    }
}

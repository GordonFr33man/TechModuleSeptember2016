using System;
using System.Linq;

class Program
{
    static void Main()
    {

        long n = long.Parse(Console.ReadLine());
        string name = englishName(n);
        Console.WriteLine(name);
    }

    private static string englishName(long num)
    {
        string lastDigit = "";
        
        long lastNumber = Math.Abs(num % 10);
        switch (lastNumber)
        {
            case 0:
                lastDigit = "zero";
                break;
            case 1:
                lastDigit = "one";
                break;
            case 2:
                lastDigit = "two";
                break;
            case 3:
                lastDigit = "three";
                break;
            case 4:
                lastDigit = "four";
                break;
            case 5:
                lastDigit = "five";
                break;
            case 6:
                lastDigit = "six";
                break;
            case 7:
                lastDigit = "seven";
                break;
            case 8:
                lastDigit = "eight";
                break;
            case 9:
                lastDigit = "nine";
                break;
            default:
                break;
        }//end of switch
        return lastDigit;
    }//end of englishName
}
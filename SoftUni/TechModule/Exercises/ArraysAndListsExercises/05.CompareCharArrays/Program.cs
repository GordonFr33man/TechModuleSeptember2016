using System;
using System.Linq;
class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
        }
        else if (firstArray.Length > secondArray.Length)

        {
            Console.WriteLine("{0}\n{1}", string.Join("", secondArray), string.Join("", firstArray));
        }
        else if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {

                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", secondArray), string.Join("", firstArray));
                    break;
                }
                if (secondArray[i] > firstArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
                    break;
                }
                if (secondArray[i] == firstArray[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
                    break;
                }
            }
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());
        int[] tempArray = new int[inputArray.Length - 1];
        int[] newArray = new int[inputArray.Length];
        int[] sum = new int[inputArray.Length];

        for (int rotate = 0; rotate < rotations; rotate++)
        {
            for (int i = 0; i < tempArray.Length; i++)
                tempArray[i] = inputArray[i];

            newArray[0] = inputArray[inputArray.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
                newArray[i + 1] = tempArray[i];

            inputArray = newArray;

            for (int i = 0; i < inputArray.Length; i++)
                sum[i] += newArray[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
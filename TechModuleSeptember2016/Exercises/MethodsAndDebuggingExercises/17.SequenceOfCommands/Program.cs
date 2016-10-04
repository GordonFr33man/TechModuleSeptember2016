using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] inputElemnts = command.Split(ArgumentsDelimiter);
            if (inputElemnts.Length == 1)
            {
                if (inputElemnts[0].Equals("rshift"))
                {
                    ArrayShiftRight(array);
                }
                else if (inputElemnts[0].Equals("lshift"))
                {
                    ArrayShiftLeft(array);
                }
            }
            else
            {
                string action = inputElemnts[0];
                int[] args = new int[2];
                args[0] = int.Parse(inputElemnts[1]);
                args[1] = int.Parse(inputElemnts[2]);

                PerformAction(array, action, args);
            }

            PrintArray(array);
            Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] array, string action, int[] args)
    {
        //long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;

        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long a = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = a;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
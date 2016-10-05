using System;

class LargestCommonEnd
{
    static void Main()
    {
        string[] str1 = Console.ReadLine().Split(' ');
        string[] str2 = Console.ReadLine().Split(' ');

        bool isStr1LongerOrEqual = str1.Length >= str2.Length;
        bool isStr1LengthEq1 = str1.Length == 1;
        bool isStr2LengthEq1 = str2.Length == 1;

        if (!isStr1LengthEq1 && !isStr2LengthEq1)
        {
            int leftSide = LeftToRightScan(str1, str2, isStr1LongerOrEqual);
            int rightSide = RightToLsftScan(str1, str2, isStr1LongerOrEqual);
            bool isLeftSideLarger = leftSide > rightSide;

            if (isLeftSideLarger)
            {
                Console.WriteLine(leftSide);
            }
            else
            {
                Console.WriteLine(rightSide);
            }

        }
        else if (isStr1LengthEq1 || isStr2LengthEq1)
        {
            Console.WriteLine(LeftToRightScan(str1, str2, isStr1LongerOrEqual));
        }
    }

    private static int LeftToRightScan(string[] str1, string[] str2, bool isStr1LongerOrEqual)
    {
        int counter = 0;
        if (isStr1LongerOrEqual)
        {
            for (int i = 0; i < str2.Length; i++)
            {
                bool areElementsEqual = str1[i] == str2[i];

                if (areElementsEqual)
                {
                    counter += 1;
                }
            }
            return counter;
        }
        else
        {
            for (int i = 0; i < str1.Length; i++)
            {
                bool areElementsEqual = str1[i] == str2[i];

                if (areElementsEqual)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }

    private static int RightToLsftScan(string[] str1, string[] str2, bool isStr1LongerOrEqual)
    {
        int counter = 0;
        if (isStr1LongerOrEqual)
        {
            for (int i = str1.Length - 1; i >= str2.Length - 1; i--)
            {
                bool areElementsEqual = str1[i] == str2[i - (str1.Length - str2.Length)];

                if (areElementsEqual)
                {
                    counter += 1;
                }
            }
            return counter;
        }
        else
        {
            for (int i = str2.Length - 1; i >= str1.Length - 1; i--)
            {
                bool areElementsEqual = str1[i - (str2.Length - str1.Length)] == str2[i];

                if (areElementsEqual)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}
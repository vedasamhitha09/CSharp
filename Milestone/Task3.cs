using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        int smallestDigit1 = MinDigit(input1);
        int largestDigit2 = MaxDigit(input2);
        int smallestDigit3 = MinDigit(input3);

        int product = smallestDigit1 * largestDigit2 * smallestDigit3;
        int pin = product - input4;

        return pin;
    }

    private static int MaxDigit(int number)
    {
        int maxDigit = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }
            number /= 10;
        }
        return maxDigit;
    }

    private static int MinDigit(int number)
    {
        int minDigit = 9;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit < minDigit)
            {
                minDigit = digit;
            }
            number /= 10;
        }
        return minDigit;
    }

    static void Main(string[] args)
    {
        int input1 = 3521;
        int input2 = 2452;
        int input3 = 1352;
        int input4 = 38;

        int pin = FindPIN(input1, input2, input3, input4);
        Console.WriteLine("The PIN is: " + pin);
    }
}

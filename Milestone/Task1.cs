using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        int maxDigit1 = MaxDigit(input1);
        int minDigit1 = MinDigit(input1);
        int maxDigit2 = MaxDigit(input2);
        int minDigit2 = MinDigit(input2);
        int maxDigit3 = MaxDigit(input3);
        int minDigit3 = MinDigit(input3);

        int result1 = maxDigit1 * minDigit1;
        int result2 = maxDigit2 * minDigit2;
        int result3 = maxDigit3 * minDigit3;

        int product = result1 * result2 * result3;
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

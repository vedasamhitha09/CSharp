using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        int largestDigit1 = MaxDigit(input1);
        int largestDigit2 = MaxDigit(input2);
        int largestDigit3 = MaxDigit(input3);

        int product = largestDigit1 * largestDigit2 * largestDigit3;
        int pin = product + input4;

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

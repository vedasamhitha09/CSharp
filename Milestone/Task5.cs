using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        int sum = 0;

        if (input4 % 2 == 0)
        {
            // input4 is even, sum even digits
            sum = SumEvenDigits(input1) + SumEvenDigits(input2) + SumEvenDigits(input3);
        }
        else
        {
            // input4 is odd, sum odd digits
            sum = SumOddDigits(input1) + SumOddDigits(input2) + SumOddDigits(input3);
        }

        return sum;
    }

    private static int SumEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    private static int SumOddDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int input1 = 3521;
        int input2 = 2452;
        int input3 = 1352;
        int input4 = 38;

        int pin = FindPIN(input1, input2, input3, input4);
        Console.WriteLine("The PIN is: " + pin);

        input4 = 37;
        pin = FindPIN(input1, input2, input3, input4);
        Console.WriteLine("The PIN is: " + pin);
    }
}

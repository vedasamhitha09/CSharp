using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        // Initialize sums
        int sumEven = 0;
        int sumOdd = 0;

        // Process each number
        ProcessNumber(input1, ref sumEven, ref sumOdd);
        ProcessNumber(input2, ref sumEven, ref sumOdd);
        ProcessNumber(input3, ref sumEven, ref sumOdd);

        // Determine the PIN based on input4
        if (input4 % 2 == 0)
        {
            // input4 is EVEN
            return sumEven - sumOdd;
        }
        else
        {
            // input4 is ODD
            return sumOdd - sumEven;
        }
    }

    private static void ProcessNumber(int number, ref int sumEven, ref int sumOdd)
    {
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
            number /= 10;
        }
    }

    static void Main(string[] args)
    {
        int input1 = 3521;
        int input2 = 2452;
        int input3 = 1352;
        int input4 = 38;

        int pin = FindPIN(input1, input2, input3, input4);
        Console.WriteLine("The PIN is: " + pin);  // Output should be -11

        input4 = 37;
        pin = FindPIN(input1, input2, input3, input4);
        Console.WriteLine("The PIN is: " + pin);  // Output should be 11
    }
}

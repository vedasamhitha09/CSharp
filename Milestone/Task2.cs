using System;

class MathsGame
{
    public static int FindPIN(int input1, int input2, int input3, int input4)
    {
        int sumEvenPositions = SumDigitsAtPositions(input1, true) + SumDigitsAtPositions(input2, true) + SumDigitsAtPositions(input3, true);
        int sumOddPositions = SumDigitsAtPositions(input1, false) + SumDigitsAtPositions(input2, false) + SumDigitsAtPositions(input3, false);

        if (input4 % 2 == 0)
        {
            // input4 is even
            return sumEvenPositions - sumOddPositions;
        }
        else
        {
            // input4 is odd
            return sumOddPositions - sumEvenPositions;
        }
    }

    private static int SumDigitsAtPositions(int number, bool evenPositions)
    {
        string numberStr = number.ToString();
        int sum = 0;

        for (int i = 0; i < numberStr.Length; i++)
        {
            // Positions are 1-based, so add 1 to i for correct position
            if ((i + 1) % 2 == 0 == evenPositions)
            {
                sum += numberStr[i] - '0';
            }
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

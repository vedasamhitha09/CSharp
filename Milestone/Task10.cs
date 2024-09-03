using System;
using System.Linq;

class DigitalLock
{
    public static int GeneratePIN(int input1, int input2, int input3)
    {
        int[] digitsCount = new int[10];
        CountDigits(input1, digitsCount);
        CountDigits(input2, digitsCount);
        CountDigits(input3, digitsCount);

        int smallestDigit = GetSmallestDigit(input1, input2, input3);
        int largestDigit = GetLargestDigit(input1, input2, input3);
        int minFrequencyDigit = GetMinFrequencyDigit(digitsCount);
        int maxFrequencyDigit = GetMaxFrequencyDigit(digitsCount);

        int pin = smallestDigit * 1000 + largestDigit * 100 + minFrequencyDigit * 10 + maxFrequencyDigit;
        return pin;
    }

    private static void CountDigits(int number, int[] digitsCount)
    {
        while (number > 0)
        {
            int digit = number % 10;
            digitsCount[digit]++;
            number /= 10;
        }
    }

    private static int GetSmallestDigit(int input1, int input2, int input3)
    {
        int smallest = 9;
        smallest = Math.Min(smallest, GetSmallestDigitInNumber(input1));
        smallest = Math.Min(smallest, GetSmallestDigitInNumber(input2));
        smallest = Math.Min(smallest, GetSmallestDigitInNumber(input3));
        return smallest;
    }

    private static int GetLargestDigit(int input1, int input2, int input3)
    {
        int largest = 0;
        largest = Math.Max(largest, GetLargestDigitInNumber(input1));
        largest = Math.Max(largest, GetLargestDigitInNumber(input2));
        largest = Math.Max(largest, GetLargestDigitInNumber(input3));
        return largest;
    }

    private static int GetSmallestDigitInNumber(int number)
    {
        int smallest = 9;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit < smallest)
            {
                smallest = digit;
            }
            number /= 10;
        }
        return smallest;
    }

    private static int GetLargestDigitInNumber(int number)
    {
        int largest = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > largest)
            {
                largest = digit;
            }
            number /= 10;
        }
        return largest;
    }

    private static int GetMinFrequencyDigit(int[] digitsCount)
    {
        int minFrequency = digitsCount.Where(d => d > 0).Min();
        for (int i = 0; i <= 9; i++)
        {
            if (digitsCount[i] == minFrequency)
            {
                return i;
            }
        }
        return -1; // This should never be reached
    }

    private static int GetMaxFrequencyDigit(int[] digitsCount)
    {
        int maxFrequency = digitsCount.Max();
        for (int i = 9; i >= 0; i--)
        {
            if (digitsCount[i] == maxFrequency)
            {
                return i;
            }
        }
        return -1; // This should never be reached
    }

    static void Main(string[] args)
    {
        int input1 = 1724;
        int input2 = 5283;
        int input3 = 1937;

        int pin = GeneratePIN(input1, input2, input3);
        Console.WriteLine("The PIN is: " + pin);  // Output should be 1947
    }
}

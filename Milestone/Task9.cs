using System;
using System.Collections.Generic;
using System.Linq;

class DigitalLock
{
    public static int GeneratePIN(int input1, int input2, int input3)
    {
        int[] digits = new int[10];
        CountDigits(input1, digits);
        CountDigits(input2, digits);
        CountDigits(input3, digits);

        int maxFrequencyDigit = GetMaxFrequencyDigit(digits);
        int minFrequencyDigit = GetMinFrequencyDigit(digits);
        int largestDigit = GetLargestDigit(input1, input2, input3);
        int smallestDigit = GetSmallestDigit(input1, input2, input3);

        int pin = maxFrequencyDigit * 1000 + minFrequencyDigit * 100 + largestDigit * 10 + smallestDigit;
        return pin;
    }

    private static void CountDigits(int number, int[] digits)
    {
        while (number > 0)
        {
            int digit = number % 10;
            digits[digit]++;
            number /= 10;
        }
    }

    private static int GetMaxFrequencyDigit(int[] digits)
    {
        int maxFrequency = digits.Max();
        for (int i = 9; i >= 0; i--)
        {
            if (digits[i] == maxFrequency)
            {
                return i;
            }
        }
        return -1;
    }

    private static int GetMinFrequencyDigit(int[] digits)
    {
        int minFrequency = digits.Where(d => d > 0).Min();
        for (int i = 0; i <= 9; i++)
        {
            if (digits[i] == minFrequency)
            {
                return i;
            }
        }
        return -1;
    }

    private static int GetLargestDigit(int input1, int input2, int input3)
    {
        int largest = 0;
        largest = Math.Max(largest, GetLargestDigit(input1));
        largest = Math.Max(largest, GetLargestDigit(input2));
        largest = Math.Max(largest, GetLargestDigit(input3));
        return largest;
    }

    private static int GetLargestDigit(int number)
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

    private static int GetSmallestDigit(int input1, int input2, int input3)
    {
        int smallest = 9;
        smallest = Math.Min(smallest, GetSmallestDigit(input1));
        smallest = Math.Min(smallest, GetSmallestDigit(input2));
        smallest = Math.Min(smallest, GetSmallestDigit(input3));
        return smallest;
    }

    private static int GetSmallestDigit(int number)
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

    static void Main(string[] args)
    {
        int input1 = 1724;
        int input2 = 5283;
        int input3 = 1937;

        int pin = GeneratePIN(input1, input2, input3);
        Console.WriteLine("The PIN is: " + pin);  // Output should be 7491
    }
}

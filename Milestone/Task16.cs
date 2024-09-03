using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
        int result = SumOfPrimeIndexValues(array);
        Console.WriteLine("The sum of values at prime indexes is: " + result);
    }

    // Function to determine if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Function to calculate the sum of values at prime indexes
    public static int SumOfPrimeIndexValues(int[] array)
    {
        int sum = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (IsPrime(i))
            {
                sum += array[i];
            }
        }
        
        return sum;
    }
}

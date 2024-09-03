using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input1 = {10, 41, 18, 50, 43, 31, 29, 25, 59, 96, 67};
        int input2 = input1.Length;

        int result = SumOfPrimesExcludingSmallest(input1);
        Console.WriteLine("The result is: " + result);
    }

    public static int SumOfPrimesExcludingSmallest(int[] array)
    {
        // Find all prime numbers in the array
        var primes = array.Where(IsPrime).ToList();

        if (primes.Count == 0)
        {
            // No prime numbers found, return the sum excluding the smallest number
            int smallest = array.Min();
            return array.Where(x => x != smallest).Sum();
        }

        // Find the smallest prime number
        int smallestPrime = primes.Min();

        // Calculate the sum of all primes excluding the smallest prime
        int sumPrimes = primes.Where(x => x != smallestPrime).Sum();
        return sumPrimes;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
}

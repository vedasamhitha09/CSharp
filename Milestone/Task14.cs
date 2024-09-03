using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input1 = {1, 2, 4, 1, 2, 8};
        int input2 = input1.Length;

        int result = FindFirstRepeatedFromTail(input1);
        Console.WriteLine("The result is: " + result);
    }

    public static int FindFirstRepeatedFromTail(int[] array)
    {
        // Filter out negative numbers and zeros
        var filteredArray = array.Where(x => x > 0).ToArray();
        
        // If there are no positive numbers, return 0
        if (filteredArray.Length == 0)
        {
            return 0;
        }

        // Use a HashSet to keep track of seen numbers
        HashSet<int> seen = new HashSet<int>();

        // Traverse the array from the end to the beginning
        for (int i = filteredArray.Length - 1; i >= 0; i--)
        {
            if (seen.Contains(filteredArray[i]))
            {
                return filteredArray[i];
            }
            seen.Add(filteredArray[i]);
        }

        // If no repeated element is found, return the last element of the original array
        return array.Last();
    }
}

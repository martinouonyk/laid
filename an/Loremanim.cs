using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, world!");
        
        // Example usage of selecting from a distribution
        int[] distribution = { 1, 2, 3, 4, 5 };
        int i = 0; // first select distribution

        for (i = 0; i < distribution.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {distribution[i]}");
        }
    }
}

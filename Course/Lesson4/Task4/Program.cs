﻿namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        Console.WriteLine("Четные числа в массиве: ");
        
        foreach (int num in numbers)
        {
            if (num %  2 == 0)
            {
                Console.Write(num + " ");
            }

        }
    }
}

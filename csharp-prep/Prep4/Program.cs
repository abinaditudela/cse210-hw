using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;  // Start with any number other than 0

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Keep tracking for numbers until the user enters 0
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number); 
            }
        }

        // calculate sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the list of numbers is: {sum}");

        // Calculate average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find maximum
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The maximun number is: {max}");

        // Stretch challenge: Find smallest positive number
        int smallest = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallest)
            {
                smallest = num;
            }
        }

        if (smallest != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        //sorting list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
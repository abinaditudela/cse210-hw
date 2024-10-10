using System;

class Program
{
    static void Main(string[] args)
    {
                // Test Fraction class with all three constructors

        // 1st Constructor: 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());  // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());    // Output: 1

        // 2nd Constructor: 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());  // Output: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());    // Output: 5

        // 3rd Constructor: 3/4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());  // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());    // Output: 0.75

        // Modify fraction with setters and display using getters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine(fraction3.GetFractionString());  // Output: 1/3
        Console.WriteLine(fraction3.GetDecimalValue());    // Output: 0.3333333333333333
    }
}
using System;

namespace C__Practice.Integer;

public class Calculator
{
    public static void Calculators()
    {
        Console.WriteLine("Enter the first number:");
        int? n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        string? n2 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        int? n3 = Convert.ToInt32(Console.ReadLine());

        switch (n2)
        {
            case "+":
                Console.WriteLine($"Result: {n1 + n3}");
                break;
            case "-":
                Console.WriteLine($"Result: {n1 - n3}");
                break;
            case "*":
                Console.WriteLine($"Result: {n1 * n3}");
                break;
            case "/":
                if (n3 != 0)
                {
                    Console.WriteLine($"Result: {n1 / n3}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator, Please use +, -, *, or /.");
                break;
        }
    }
}

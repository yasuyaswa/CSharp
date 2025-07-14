using System;

namespace CSharp.Integer;

public class SwapTwoNumbersWithoutTemp
{
    public static void SwapNumber()
    {
        int a = 5;
        int b = 3;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a: {a}, b: {b}");
    }
}

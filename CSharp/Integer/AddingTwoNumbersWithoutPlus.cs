using System;

namespace CSharp.Integer;

public class AddingTwoNumbersWithoutPlus
{
    public static void AddingTwoNumbers()
    {
        int a = 5;
        int b = 3;
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        Console.WriteLine(a);
    }
}

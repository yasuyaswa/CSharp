using System;

namespace CSharp.Integer;

public class PrimeCheck
{
    public static bool PrimeChecks(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

namespace C__Practice;

public class PatternPyramidWithNumbersRightAngle
{
    public static void PatternNumber(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

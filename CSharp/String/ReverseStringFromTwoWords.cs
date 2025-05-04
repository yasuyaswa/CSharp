using System;

namespace C__Practice.String;

public class ReverseStringFromTwoWords
{
    public static void ReverseStringFromTwoWord(string input)
    {
        string[] words = input.Split(' ');
        string a = words[0];
        string b = words[1];
        string result1 = string.Empty;
        string result2 = string.Empty;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            result1 += a[i];
        }
        for (int j = b.Length - 1; j >= 0; j--)
        {
            result2 += b[j];
        }
        Console.WriteLine(result1 + " " + result2);
    }
}

using System;
using System.Text;
namespace C__Practice.String;

public class ReverseStringFromTwoWords
{
    public static void ReverseStringFromTwoWord(string input)
    {
        string[] words = input.Split(" ");
        string str1 = words[0];
        string str2 = words[1];

        StringBuilder r1 = new StringBuilder();
        StringBuilder r2 = new StringBuilder();

        for (int i = str1.Length - 1; i >= 0; i--)
        {
            r1.Append(str1[i]);
        }

        for (int i = str2.Length - 1; i >= 0; i--)
        {
            r2.Append(str2[i]);
        }

        Console.WriteLine(r1 + " " + r2);
    }
}

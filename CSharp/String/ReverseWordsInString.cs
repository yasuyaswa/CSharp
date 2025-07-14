using System;
using System.Text;
namespace C__Practice.String;

public class ReverseWordsInString
{
    public static void ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        StringBuilder result = new StringBuilder();

        foreach (string item in words)
        {
            for (int i = item.Length-1; i >= 0; i--)
            {
                result.Append(item[i]);
            }
            result.Append(' ');
        }
        Console.WriteLine(result);
    }
}

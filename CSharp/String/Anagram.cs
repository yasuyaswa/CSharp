using System;

public class Anagram
{
    public static void Anagrams()
    {
        Console.WriteLine("Enter the string1: ");
        string? str1 = Console.ReadLine()?.Trim().ToLower();

        Console.WriteLine("Enter the string2: ");
        string? str2 = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Given strings are not anagrams.");
            return;
        }

        string sorted1 = SortArray(str1);
        string sorted2 = SortArray(str2);

        if (sorted1 == sorted2)
        {
            Console.WriteLine("Given strings are anagrams.");
        }
        else
        {
            Console.WriteLine("Given strings are not anagrams.");
        }
    }

    public static string SortArray(string input)
    {
        char[] CharArr = input.ToCharArray();

        for (int i = 0; i < CharArr.Length - 1; i++)
        {
            for (int j = 0; j < CharArr.Length - i - 1; j++)
            {
                if (CharArr[j] > CharArr[j + 1])
                {
                    char temp = CharArr[j];
                    CharArr[j] = CharArr[j + 1];
                    CharArr[j + 1] = temp;
                }
            }
        }

        return new string(CharArr);
    }
}

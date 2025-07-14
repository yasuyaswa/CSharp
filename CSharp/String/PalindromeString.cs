using System;

namespace CSharp.String;

public class PalindromeString
{
    public static bool Palindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;
        bool isPalindrome = true;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        return isPalindrome;
    }
}

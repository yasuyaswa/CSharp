public class ReverseStrings
{
    public static void ReverseString(string input)
    {
        // It is not a good practice, every time a new string is created as string is immutable
        // Here, we can use Array or String builder
        // string result = String.Empty;
        // for (int i = input.Length - 1; i >= 0; i--)
        // {
        //     result += input[i];
        // }
        // Console.WriteLine(result);
        int l = input.Length;
        char[] CharArray = new char[l];

        for (int i = l - 1; i >= 0; i--)
        {
            CharArray[i] = input[l - i - 1];
        }
        Console.WriteLine(CharArray);

        // Other method using string builder
        // StringBuilder result = new StringBuilder(l);
        // for (int i = l - 1; i >= 0; i--)
        // {
        //     result.Append(input[i]);
        // }
        // Console.WriteLine(result);

        //using swap left to right
        // int left = 0;
        // int right = input.Length - 1;
        // char[] CharArr = input.ToCharArray();
        // while (left < right)
        // {
        //     char temp = CharArr[left];
        //     CharArr[left] = CharArr[right];
        //     CharArr[right] = temp;
        //     left++;
        //     right--;
        // }
        // string result = new string(CharArr);
        // Console.WriteLine(result);
    }
}

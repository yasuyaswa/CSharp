public class SortStringArrayUsingMethod
{
    public static void SortUsingMethod(string input)
    {

        char[] a;
        int l = input.Length;
        a = input.ToCharArray(0, l);
        Array.Sort(a);
        Console.WriteLine(a);
    }
}
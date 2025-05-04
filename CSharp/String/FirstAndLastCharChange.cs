public class FirstAndLastCharChange
{
    public static void FirstLastCharChange(string input)
    {
        string x = input.Substring(input.Length - 1) + input.Substring(1, input.Length - 2) + input.Substring(0, 1);
        Console.WriteLine(x);
    }
}
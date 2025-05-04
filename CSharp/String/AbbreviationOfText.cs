public class AbbreviationOfText
{
    public static void Abbreviation(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = "";
        foreach (string item in words)
        {
            if (item.Length > 0)
            {
                result += item[0];
            }
        }
        Console.WriteLine(result.ToUpper());
    }
}
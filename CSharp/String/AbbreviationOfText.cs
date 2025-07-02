public class AbbreviationOfText
{
    public static void Abbreviation(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        foreach(string item in words){
        if(item.Length>0){
            result.Append(item[0]);
            }
        }
    Console.WriteLine(result.ToString().ToUpper());
    }
}

public class AlphabetPositionInString
{
    public static void AlphabetPosition(string input)
    {
        //a -> 97%32=1
        var CharPosition = input.ToLower().Where(Char.IsLetter).Select(ch => ch - 'a' + 1);
        string result = string.Join(" ", CharPosition);
        Console.WriteLine("Alphabet position in the string is " + result);
    }
}
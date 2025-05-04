public class CountAlphaNumericSymbols
{
    public static void CountAlphaNumericSymbol(string input)
    {

        int alph, digit, symb, i;
        alph = digit = symb = i = 0;
        while (i < input.Length)
        {
            if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
            {
                alph++;
            }
            else if (input[i] >= '0' && input[i] <= '9')
            {
                digit++;
            }
            else
            {
                symb++;
            }
            i++;
        }
        Console.WriteLine($"Alphabets : {alph}\nDigits : {digit}\nSymbols : {symb}");
    }
}
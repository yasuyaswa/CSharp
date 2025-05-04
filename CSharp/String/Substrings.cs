using System.Text;
public class Substrings{
    public static void Substring(string input){

        for (int i = 0; i < input.Length; i++)
            {
                StringBuilder subString = new StringBuilder();
                for (int j = i; j < input.Length; j++)
                {
                    subString.Append(input[j]);
                    Console.Write(subString + " ");
                }
            }         
    }
}
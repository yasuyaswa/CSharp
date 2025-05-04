using System.Text.RegularExpressions;
public class RegularExpressionForEmail{
    public static void RegularExpression(string input){

        string pattern = "^[A-Z0-9+_.-]+@[A-Z0-9.-]+$";
        
        if(Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase)){
            Console.WriteLine("Email is valid!");
        }else{
            Console.WriteLine("Email is invalid!");
        }
    }
}
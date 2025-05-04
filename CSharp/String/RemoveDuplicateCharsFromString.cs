public class RemoveDuplicateCharsFromString{
    public static void RemoveDuplicate(string input){

        string result = string.Empty;
        for(int i=0; i<input.Length; i++){
            if(!result.Contains(input[i])){
                result+=input[i];// result=result+input[i]
            }
        }
        Console.WriteLine(result);
       

    }
}
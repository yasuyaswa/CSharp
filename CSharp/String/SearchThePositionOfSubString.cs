public class SearchThePositionOfSubString{
    public static void SearchPositionSubString(){
        Console.WriteLine("Enter the text: ");
        string? input = Console.ReadLine();
        Console.WriteLine("Enter the text to search the position in the given text: ");
        string? FindStr = Console.ReadLine();
        int index = input.IndexOf(FindStr);
        if(index<0){
            Console.WriteLine("The substring not found in the given string");
        }else{
            Console.WriteLine($"Found  '{FindStr}' in '{input}' in the position of {index}.");
        }
    }
}
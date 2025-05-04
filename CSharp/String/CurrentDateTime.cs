public class CurrentDateTime{
    public static void CurrentDT(){
        Console.Write("Current Date and Time (IST) is: ");
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt.ToString("dddd, dd MMMM yyyy hh:mm:ss tt"));
    }
}
public class RandomString{
    public static void RandomStr(){
        Random random = new Random();
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Console.Write("Enter desired no of digits: ");
        int length = int.Parse(Console.ReadLine());
        string RandomString = new String(Enumerable.Repeat(chars, length)
        .Select(s=>s[random.Next(s.Length)]).ToArray());
        Console.WriteLine(RandomString);
    }
}
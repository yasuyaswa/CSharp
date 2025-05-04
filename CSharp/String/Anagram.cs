public class Anagram
{   //It is formed by rearranging the letters of another word or phrase, using all the original letters exactly once.
    public static void Anagrams()
    {
        Console.WriteLine("Enter the string1: ");
        string? str1 = Console.ReadLine();
        Console.WriteLine("Enter the string2: ");
        string? str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Given strings are not anagrams.");
        }
        else
        {
            char[] charArr1 = str1.ToLower().ToCharArray();
            char[] charArr2 = str2.ToLower().ToCharArray();

            Array.Sort(charArr1);
            Array.Sort(charArr2);

            string str1Sorted = new string(charArr1);
            string str2Sorted = new string(charArr2);
            if (str1Sorted == str2Sorted)
            {
                Console.WriteLine("Given strings are anagrams.");
            }
            else
            {
                Console.WriteLine("Given strings are not anagrams.");
            }
        }
    }
}

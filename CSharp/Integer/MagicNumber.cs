public class MagicNumber
{
    public static void Magic(int n)
    {   
        //Magic number means sum of digits * Reverse of sum of digits = original number.
        int sum = 0, r;
        int temp = n;
        //for sum of digits
        while (n > 0)
        {
            r = n % 10;
            sum = sum + r;
            n = n / 10;
        }
        System.Console.WriteLine(sum);
        n = sum;
        int rev = 0;
        //for reverse of digits
        while (n > 0)
        {
            r = n % 10;
            rev = rev * 10 + r;
            n = n / 10;
        }
        System.Console.WriteLine(rev);
        if (temp == rev * sum)
        {
            Console.WriteLine(temp + " is a Magic number");
        }
        else
        {
            Console.WriteLine(temp + " is not a Magic number");
        }
    }
}
public class DecimalToBinary
{
    public static void DTB(int n)
    {
        int[] a = new int[10];
        int i;
        for (i = 0; n > 0; i++)
        {
            a[i] = n % 2;
            n = n / 2;
        }
        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(a[j]);
        }
    }

    // 5 - 4-1 2-0 1-1
    // a[0]=1
    // n=2
    // a[1]=0
    // n=1
    // a[2]=1
    // n=0
    //a[]=[1,0,1]
    //i=3-1=2  a[2]=1
    //i=2-1=1 a[1]=0
    //i=1-1   a[2]=1
}

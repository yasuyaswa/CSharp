public class MinMax{
    public static void MinMaxi(){
        Console.WriteLine("Enter the length of the array: ");
        int l = Convert.ToInt32(Console.ReadLine());
        int[] a= new int[l];
        int max, min;
        for(int i = 0; i<l; i++){
            Console.Write($"Enter element {i}: ");
            a[i]= int.Parse(Console.ReadLine());
        }
        max = a[0];
        min = a[0];
        for(int i = 1; i<l; i++){
            if(a[i]<min){
                min=a[i];
            }
            if(a[i]>max){
                max= a[i];
            }
        }
        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");
    }
}
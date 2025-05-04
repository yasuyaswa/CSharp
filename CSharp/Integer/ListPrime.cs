public class ListPrime
{
    public static void prime(int n){
        for(int i=2; i<=n; i++){
            bool flag = true;
            for(int j=2; j<i; j++){
                if(i%j==0){
                    flag = false;
                    break;
                }
            }
            if(flag==true){
                System.Console.Write(i+" ");
            }
        }

    }
}
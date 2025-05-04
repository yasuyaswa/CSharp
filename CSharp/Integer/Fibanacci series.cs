class fibonacci {
 public  static int fib(int n){
      int a=0, b=1, c;
      if(n<=0){
          return a;
      }else if(n==1){
          return b;
      }else{
        Console.Write(a+" "+b+" ");
          for(int i=2; i<n; i++){
              c=a+b;
              Console.Write(c+" ");
              a=b;
              b=c;
          }
          Console.WriteLine();
          return b;
      }
    }
}

using System.Net.WebSockets;

namespace C__Practice;

public class PatternPyramidEquilateral
{
    public static void PatternEquilateral(int n){
        char ch= 'a';
        for(int i=1; i<=n; i++){
            for(int j=i; j<n; j++){
                Console.Write(" ");
            }
            for(int k=1; k<=(2*i-1); k++){
                Console.Write(ch);
            }
            ch++;
            Console.WriteLine();
        }
    }
}

using System;

namespace C__Practice.Integer;

public class GuessNumber
{
    public static void GuessNum(){
        int GuestCount =3;
        string code = "CorrectCode";

        while(GuestCount >=1){
            Console.WriteLine("Type your input");
            string ?input = Console.ReadLine();
            if(input == code){
            Console.WriteLine("You won!");
            return;
            }else{
            GuestCount--;
            Console.WriteLine("Try again, You have {0} chances left", GuestCount);
            }
        }
        Console.WriteLine("You failed to guess the number");
    }
}

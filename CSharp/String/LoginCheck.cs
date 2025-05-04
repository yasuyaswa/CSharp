public class LoginCheck{
    public static void Login(){
        string? Username;
        string? Password;
        int ctr=0;
        Console.WriteLine("Check your username and password!");
        Console.WriteLine("Default Username and Password is: abcd and 1234 respectively");
        

        do{
            Console.Write("Enter the Username: ");
            Username = Console.ReadLine();
            Console.Write("Enter the Password: ");
            Password = Console.ReadLine();
            if(Username!= "abcd" || Password!= "1234"){
                ctr++;
            }else{
                ctr=1;
            }
        }while((Username!="abcd" || Password!= "1234") && (ctr!=3));
        if(ctr==3){
            Console.WriteLine("\nLogin attempt three or more times. Try again Later!");
        }else{
            Console.WriteLine("\nLogin Successful");
        }
    }
}
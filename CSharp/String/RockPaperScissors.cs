namespace C__Practice;

public class RockPaperScissors
{
    public static void RockPaperScissor(string p1, string p2){
        Dictionary<string, string> rules = new Dictionary<string, string>
        {
            {"rock", "scissors"},
            {"paper", "rock"},
            {"scissors", "paper"}
        };
        if(p1==p2){
            Console.WriteLine("Draw.");
        }else if(p2==rules[p1]){
            Console.WriteLine("Player 1 won.");
        }else{
            Console.WriteLine("Player 2 won.");
        }
    }
}

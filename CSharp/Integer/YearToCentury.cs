namespace C__Practice;

public class YearToCentury
{
    public static void YearCentury(double year){
        double y2= year/100;
        double g= Math.Floor(y2);
        if (y2>g) {
            Console.WriteLine(g+1);
        } else {
            Console.WriteLine(g);
        }

    }
}

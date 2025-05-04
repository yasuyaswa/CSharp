public class Exception{
    public static void excep(int n1, int n2){
        try{
            Console.WriteLine(n1/n2);
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException) {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        catch (System.Exception e) {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
    }
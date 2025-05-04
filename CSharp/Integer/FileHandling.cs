public class FileHandling{
    public static void FileHandlings(){
        FileStream fs = new FileStream(@"C:\Users\YYEDUGUR\OneDrive - Capgemini\Documents\Notepad\sample.ts", FileMode.Append);
        StreamWriter sw = new StreamWriter(fs);
        Console.WriteLine("Enter the text that you need to write in the file");
        sw.WriteLine("The sun rises in the east.");
        //string input = Console.ReadLine();
        sw.Close();
        fs.Close();
        using(FileStream fs2 = new FileStream(@"C:\Users\YYEDUGUR\OneDrive - Capgemini\Documents\Notepad\sample.ts",FileMode.Open)){
            StreamReader sr = new StreamReader(fs2);
            //string str = sr.ReadLine();
            Console.WriteLine(sr.ReadToEnd());
        }
        //Console.WriteLine(str);
    }
}
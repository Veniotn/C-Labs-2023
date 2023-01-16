namespace Util;

public class Console
{
    public static string Ask(string question)
    {
       System.Console.WriteLine(question);
        return System.Console.ReadLine();
    }
}
// See https://aka.ms/new-console-template for more information

//Survey

public class Challenge1
{
    public static void Main(string[] args)
    {
        //using var as default for string or for birth months where it could either be the written month or the number out of 12.
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("What month were you born in?");
        var month = Console.ReadLine();
        
        Console.WriteLine("What is your Nationality?");
        var country = Console.ReadLine();
        
        Console.WriteLine("What is 8 / 2 ?");
        double testResult = Convert.ToDouble(Console.ReadLine());
        
        //printing results of the survey
        Console.WriteLine("Your name: " + name + "\nYour age: " + age + "\nYour birth month: " + month + "\nYour Nationality: " + country + "\nYour answer to the skill check: " +  testResult);
    }
}

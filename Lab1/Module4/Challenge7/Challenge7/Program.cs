// See https://aka.ms/new-console-template for more information

//OOP Survey
public class Challenge7
{
    public static event Action Posted;
    public static void Main(string[] args)
    {
        string name = Util.Console.Ask("What is your name?");
        int age = Util.Console.AskInt("How old are you?");
        int month = Util.Console.AskIntWithRange("What month were you born in? 1-12",1,12);
        int day = Util.Console.AskIntWithRange("What day of the month were you born? 1-31",1,31);
        var user1 = new Survey.Survey(name,age,month, day);
        Posted();
        
        Console.WriteLine("Your name: {0}\nYour age: {1}\nYour birth month: {2}\nYour zodiac: {3}",user1.Name, user1.Age, user1.Month, user1.Zodiac);
    }
}
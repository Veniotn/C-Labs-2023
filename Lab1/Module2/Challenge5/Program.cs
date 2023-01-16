// See https://aka.ms/new-console-template for more information

public class Challenge5
{
    public static void Main(string[] args)
    {
        string name = Util.Console.Ask("What is your name?");
        int age = Convert.ToInt32(Util.Console.Ask("How old are you?"));
        string month = Util.Console.Ask("What month were you born in?");
        int year = Convert.ToInt32(Util.Console.Ask("What year were you born in?"));
        var survey1 = new Survey.Survey(name,age,month, year);
        Console.WriteLine("Your name: {0}\nYour age: {1}\nYour birth month: {2}\nYour zodiac: {3}",survey1.Name, survey1.Age, survey1.Month, survey1.Zodiac);
    }
}
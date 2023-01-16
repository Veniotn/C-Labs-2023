// See https://aka.ms/new-console-template for more information

public class Challenge5
{
    public static void Main(string[] args)
    {
        string name = Util.Console.Ask("What is your name?");
        int age = Convert.ToInt32(Util.Console.Ask("How old are you?"));
        string month = Util.Console.Ask("What month were you born in?");
        string country = Util.Console.Ask("What is your nationality?");
        double testResult = Convert.ToDouble(Util.Console.Ask("What is 8 / 2 ?"));
        var survey1 = new Survey.Survey(name,age,month,country,testResult);
        Console.WriteLine("Your name: {0}\nYour age: {1}\nYour birth month: {2}\nYour Nationality: {3}\nYour answer to the skill question: {4}",survey1.Name, survey1.Age, survey1.Month, survey1.Country, survey1.TestResult);
    }
}
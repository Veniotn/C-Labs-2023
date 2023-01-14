// See https://aka.ms/new-console-template for more information

public class Challenge2
{
    public static void Main(string[] args)
    {
        bool exit = false;
        bool authenticated = false;
        var password = "secret";
        var passwordInput = "";

        while (!authenticated)
        {
            Console.WriteLine("Enter your password");
            passwordInput = Console.ReadLine();
            authenticated = passwordInput.Equals(password) ? true : false;
        }
        
        Console.WriteLine("Authenticated!");
        while (authenticated && !exit)
        {
            Console.WriteLine("Authenticated!!\n\nWelcome to the program! Would you like to change your password?\n Type (y) to change or (exit) to exit!");
            string menuRequest = Console.ReadLine();
            menuRequest.ToLower();

            if (menuRequest.Equals("exit"))
            {
                Console.WriteLine("Exiting...");
                exit=true;
            }
            else if (menuRequest.Equals("y"))
            {
                Console.WriteLine("What would you like to change your password to?");
                password = Console.ReadLine();
                Console.WriteLine("Password changed! ");
            }
            else
            {
                Console.WriteLine("Incorrect choice, site under maintenance!!");
            }
        }
    }
}
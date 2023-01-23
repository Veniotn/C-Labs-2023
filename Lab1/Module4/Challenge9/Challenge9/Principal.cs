namespace SchoolTracker;

public class Principal : MemberAccessException, IPayee
{
    public void Pay()
    {
        Console.WriteLine("Paying principal");
    }
}
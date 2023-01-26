namespace SchoolTracker;
//oop interface student teacher portal
public class Principal : MemberAccessException, IPayee
{
    public void Pay()
    {
        Console.WriteLine("Paying principal");
    }
}
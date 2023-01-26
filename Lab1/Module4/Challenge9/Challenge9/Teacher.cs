namespace SchoolTracker;
//oop interface student teacher portal
public class Teacher : Member, IPayee
{
    public string Subject;

    public void Pay()
    {
        Console.WriteLine("Paying teacher");
    }
}
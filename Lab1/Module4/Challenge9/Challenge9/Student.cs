namespace SchoolTracker;




public class Student : Member, IGraduate
{
  
    private string wNumber;
    private int grade;


    public void Graduate()
    {
        Console.WriteLine("Student {0} Graduated!", this.name);
    }


    public string WNumber
    {
        get => wNumber;
        set => wNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Grade
    {
        get => grade;
        set => grade = value;
    }
}
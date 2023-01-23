namespace SchoolTracker;



public class Member
{
    protected string name;
    protected string address;
    protected int phone;
    protected string birthday;


    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Address
    {
        get => address;
        set => address = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Phone
    {
        get => phone;
        set => phone = value;
    }

    public string Birthday
    {
        get => birthday;
        set => birthday = value ?? throw new ArgumentNullException(nameof(value));
    }
}
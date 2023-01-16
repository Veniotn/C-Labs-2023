namespace Survey;

public class Survey
{
    public string name;
    private int age;
    private string month;
    private string country;
    private double testResult;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Month
    {
        get => month;
        set => month = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Country
    {
        get => country;
        set => country = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double TestResult
    {
        get => testResult;
        set => testResult = value;
    }
    

    public Survey(string name, int age, string month, string country, double testResult)
    {
        this.name = name;
        this.age = age;
        this.month = month;
        this.country = country;
        this.testResult = testResult;
    }
}
using System.Diagnostics;

namespace Survey;

public class Survey
{
    public string name;
    private int age;
    private string month;
    private string zodiac;
    private int birthYear;

    public int BirthYear
    {
        get => birthYear;
        set => birthYear = value;
    }

    public string Zodiac
    {
        get => zodiac;
        set => zodiac = value ?? throw new ArgumentNullException(nameof(value));
    }

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
    
    public Survey(string name, int age, string month, int year)
    {
        this.name = name;
        this.age = age;
        this.month = month;
        this.birthYear = year;
        switch(year)
        {
            case 1997:
                this.zodiac = "Aquarius";
                break;
            default:
                this.zodiac = "none";
                break;
        }
    }
}
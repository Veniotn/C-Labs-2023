using System.Diagnostics;

namespace Survey;

public class Survey
{
    public string name;
    private int age;
    private int month;
    private int birthday;
    private string zodiac;
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

    public int Month
    {
        get => month;
        set => month = value;
    }

    public int Birthday
    {
        get => birthday;
        set => birthday = value;
    }

    public Survey(string name, int age, int month, int day)
    {
        this.name = name;
        this.age = age;
        this.month = month;
        this.birthday = day;
        this.zodiac = getZodiac(this.month, this.birthday);

    }


    public string getZodiac(int month, int day)
    {
        switch (month)
        {
            case 1:
                return day < 20 ? "Capricorn" : "Aquarius";
            case 2:
                return day < 19 ? "Aquarius" : "Pisces";
            case 3:
                return day < 21 ? "Pisces" : "Aries";
            case 4:
                return day < 20 ? "Aries" : "Taurus";
            case 5:
                return day < 21 ? "Taurus" : "Gemini";
            case 6:
                return day < 22 ? "Gemini" : "Cancer";
            case 7:
                return day < 23 ? "Cancer" : "Leo";
            case 8:
                return day < 22 ? "Leo" : "Virgo";
            case 9:
                return day < 23 ? "Virgo" : "Libra";
            case 10:
                return day < 23 ? "Libra" : "Scorpio";
            case 11:
                return day < 23 ? "Scorpio" : "Sagittarius";
            case 12:
                return day < 22 ? "Sagittarius" : "Capricorn";
            default:
                return "Please enter a month between 1-12";
        }
    }
}
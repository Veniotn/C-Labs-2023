namespace Survey;
//OOP Survey
public class Survey
{
    

    private enum zodiacMonth
    {
        january = 1,
        feburary = 2,
        march,
        april,
        may,
        june,
        july,
        august,
        september,
        october,
        november,
        december
    };

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
            switch (this.month)
            {
                case (int) zodiacMonth.january:
                    return day < 20 ? "Capricorn" : "Aquarius";
                case (int) zodiacMonth.feburary:
                    return day < 19 ? "Aquarius" : "Pisces";
                case (int) zodiacMonth.march:
                    return day < 21 ? "Pisces" : "Aries";
                case (int) zodiacMonth.april :
                    return day < 20 ? "Aries" : "Taurus";
                case (int) zodiacMonth.may :
                    return day < 21 ? "Taurus" : "Gemini";
                case (int) zodiacMonth.june :
                    return day < 22 ? "Gemini" : "Cancer";
                case (int) zodiacMonth.july :
                    return day < 23 ? "Cancer" : "Leo";
                case (int) zodiacMonth.august :
                return day < 22 ? "Leo" : "Virgo";
                case (int) zodiacMonth.september :
                    return day < 23 ? "Virgo" : "Libra";
                case (int) zodiacMonth.october :
                    return day < 23 ? "Libra" : "Scorpio";
                case (int) zodiacMonth.november :
                    return day < 23 ? "Scorpio" : "Sagittarius";
                case (int) zodiacMonth.december :
                    return day < 22 ? "Sagittarius" : "Capricorn";
                default:
                    return "Please enter a month between 1-12";
            }
        }
}
namespace Module2;

public class Contractor : IWorker
{

    public new string CalculateWeeklySalary(int weeklyHours, int wage)
    {
        var salary = weeklyHours * wage;
        string result = $"\nThis HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                        $"Paid for {weeklyHours} hrs at $ {wage}" +
                        $"/hr = ${salary} ";
        Console.Write("\n" + result + "\n");
        Console.WriteLine("---------------------------------------------\n");
        return result;
    }
    
}
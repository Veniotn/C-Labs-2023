namespace Module2;

public class Employee : IWorker
{
    public string CalculateWeeklySalary(int weeklyHours, int wage)
    {
    
        var salary = 40 * wage;
        string result = $"\nThis ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                        $"Paid for 40 hrs at $ {wage}" +
                        $"/hr = ${salary} \n";
        Console.Write("\n" + result + "\n");
        Console.WriteLine("---------------------------------------------\n");
        return result;
    }
}
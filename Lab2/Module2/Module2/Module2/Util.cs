namespace Module2;

public static class Util
{
    public static List<Employee> GetEmployees()
    {
        var someEmployee = new Employee();
        var everyone = new List<Employee> { someEmployee};
        return everyone;
    }

    public static List<Contractor> getContractors()
    {
        var someContractor = new Contractor();
        var contractors = new List<Contractor> { someContractor };
        return contractors;
    }
}
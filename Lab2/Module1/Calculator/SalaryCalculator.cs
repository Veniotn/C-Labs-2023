using System;

namespace Calculator;


public class SalaryCalculator
{
    const int hoursInYear = 2080;
    
    public decimal GetAnnualSalary(decimal hourlyWage)
    {
        decimal result = hourlyWage * hoursInYear;
        if (result <= 0)
        {
            throw new InvalidOperationException("Hourly wage must be greater than zero.");
        }

        return result;

    }


    public decimal getHourlyWage(int salary)
    {
        decimal result = salary / hoursInYear;
        if (result <= 0)
        {
            throw new InvalidOperationException("Yearly salary must be greater than zero.");
        }

        return result;
    }

    public TaxData TaxWithheld(double weeklySalary, int numDependants)
    {
        if (numDependants < 0)
        {
            throw new InvalidOperationException("Number dependents cannot be negative.");
        }

        if (weeklySalary <= 0)
        {
            throw new InvalidOperationException("Weekly salary must be greater than zero.");
        }
        
        const double provincialTaxRate = .06;
        const double federalTaxRate = .25;
        const double dependantRate = .02;
        
        double oneDependant = weeklySalary * dependantRate;
        double dependantDeduction = oneDependant * numDependants;
        
        double provincialTaxWithheld = weeklySalary * provincialTaxRate;
        double federalTaxWithHeld = weeklySalary * federalTaxRate;
        double totalWithHeld = (provincialTaxWithheld + federalTaxWithHeld) - dependantDeduction;
        double totalTakeHome = weeklySalary - totalWithHeld;
        
        return new TaxData(provincialTaxWithheld,federalTaxWithHeld,dependantDeduction, totalWithHeld, totalTakeHome);
    }



}
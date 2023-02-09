// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Module2
{
    
    public class Program
    {

        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            List<Employee> employees = Util.GetEmployees();
            List<Contractor> contractors = Util.getContractors();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
            
            foreach (var c in contractors)
            {
                c.CalculateWeeklySalary(hours, wage);
            }
        }


    }
}
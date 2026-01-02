using System;
using System.Collections.Generic;
using System.Text;

namespace Alisson_sCompany
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee ()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void IncreaseSalary(double percentage)
        {
            Salary *= (1 + percentage / 100); 
        }

        public override string ToString() =>
            $"""
            Id: {Id}
            Name: {Name}
            Salary; {Salary:F2}
            """;


       
    }
}

using Alisson_sCompany;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AlissonCompany;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Employee will be registered? ");
            int employeeRegistered = Convert.ToInt16(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

        for (int i = 0; i < employeeRegistered; i++)
            {
             Console.WriteLine($"Employee #{i}");
             employees.Add(new Employee());
       
        foreach (Employee employee in employees)
        {
           Console.WriteLine(employee);
        }
            }


        }
    }

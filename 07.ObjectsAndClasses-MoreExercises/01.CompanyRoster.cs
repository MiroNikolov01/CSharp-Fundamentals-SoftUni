using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> departmentEmployees = new();
            int countEmployees = int.Parse(Console.ReadLine());

         
            for (int i = 0; i < countEmployees; i++)
            {
                string[] information = Console.ReadLine().Split();
                string name = information[0];
                decimal salary = decimal.Parse(information[1]);
                string department = information[2];

                Employee employee = new Employee(name, salary, department);

             
                if (!departmentEmployees.ContainsKey(department))
                {
                    departmentEmployees[department] = new List<Employee> { employee };
                }
                else
                {
                    departmentEmployees[department].Add(employee);
                }
            }

            string highestAverageDepartment = departmentEmployees
                .OrderByDescending(d => d.Value.Average(e => e.Salary))
                .First().Key;

            Console.WriteLine($"Highest Average Salary: {highestAverageDepartment}");

            foreach (var employee in departmentEmployees[highestAverageDepartment].OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}

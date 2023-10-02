using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        private string firstName;
        private string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double CalculateSalary(string position, int experience)
        {
            double baseSalary = 0.0;

            switch (position.ToLower())
            {
                case "junior":
                    baseSalary = 20000.0;
                    break;
                case "middle":
                    baseSalary = 40000.0;
                    break;
                case "senior":
                    baseSalary = 60000.0;
                    break;
                default:
                    Console.WriteLine("Something went wrong, please check the text you entered");
                    return 0.0;
            }

            double experienceBonus = experience * 1000.0;

            double totalSalary = baseSalary + experienceBonus;

            double tax = 0.10 * totalSalary;

            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Surname: {lastName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {totalSalary:C}");
            Console.WriteLine($"Tax: {tax:C}");

            return totalSalary;
        }
    }
}

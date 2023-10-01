using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
            Position = "";
            Experience = 0;
        }

        public double CalculateSalary()
        {
            // Здесь можно добавить логику расчета оклада
            // в зависимости от посады и стажа сотрудника
            double baseSalary = 0; // Базовый оклад
            double taxRate = 0.2;  // Налоговая ставка (пример)

            double salary = baseSalary * (1 - taxRate);
            return salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Посада: {Position}");
            double salary = CalculateSalary();
            Console.WriteLine($"Оклад: {salary}");
            Console.WriteLine($"Налоговый сбор: {salary * 0.2}"); // Пример налогового сбора
        }
    }
}

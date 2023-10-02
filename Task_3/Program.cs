namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the employee's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the employee's position (junior, middle, senior): ");
            string position = Console.ReadLine();

            Console.Write("Enter the employee's expirience (years): ");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName);
            employee.CalculateSalary(position, experience);
        }


    }

}
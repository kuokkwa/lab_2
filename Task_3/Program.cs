namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("Иванов", "Иван");
            employee.Position = "Инженер";
            employee.Experience = 5;

            employee.DisplayInfo();

            // Пауза перед завершением программы
            Console.ReadLine();
        }


    }

}
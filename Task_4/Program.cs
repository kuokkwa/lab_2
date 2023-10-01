namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user", "John", "Brown", 5);

            user.DisplayUserInfo();

            Console.ReadLine();
        }
    }
}
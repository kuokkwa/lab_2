namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter money = new Converter(37.01, 39.18, 8.47, 4);
            Console.WriteLine("Курси валют: ");
            Console.WriteLine("USD: {0}, \nEUR: {1}, \nPLN: {2}, \nEntered amount: {3}", money.GetUsd(), money.GetEur(), money.GetPln(), money.GetUah());
            money.MethodUsd();
            Console.WriteLine(money.MethodUsd());
            Console.ReadKey();
        }
    }
}
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter money = new Converter(37.01, 39.18, 8.46, 1);
            Console.WriteLine("Exchange rates: ");
            Console.WriteLine("USD: {0}, \nEUR: {1}, \nPLN: {2}, \nEntered amount: {3}", money.GetUsd(), money.GetEur(), money.GetPln(), money.GetUah());
            Console.WriteLine("USD: {0}", money.MethodUsd(37.01, money.GetUah(), 1));
            Console.WriteLine("EUR: {0}", money.MethodEur(39.18, money.GetUah(), 1));
            Console.WriteLine("PLN: {0}", money.MethodPln(8.46, money.GetUah(), 1));
            Console.ReadKey();
        }
    }
} 
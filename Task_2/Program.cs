namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdRate = 36.75;
            double eurRate = 38.71;
            double plnRate = 8.4;

            Converter converter = new Converter(usdRate, eurRate, plnRate);

            while (true)
            {
                Console.WriteLine("Choose the conversion operation:");
                Console.WriteLine("(UAH) - convert from UAH to other currencies");
                Console.WriteLine("(Other) - convert from other currencies to UAH");
                Console.WriteLine("(Exit) - to end the program");

                string choice = Console.ReadLine();

                if (choice == "UAH")
                {
                    Console.Write("Enter the amount in UAH: ");
                    double amount = double.Parse(Console.ReadLine());
                    Console.Write("Choose currency (USD, EUR, PLN): ");
                    string currency = Console.ReadLine();

                    double result = 0.0;
                    if (currency == "USD")
                    {
                        result = converter.ConvertToUSD(amount);
                        Console.WriteLine($"{amount} UAH = {result} USD");
                    }
                    else if (currency == "EUR")
                    {
                        result = converter.ConvertToEUR(amount);
                        Console.WriteLine($"{amount} UAH = {result} EUR");
                    }
                    else if (currency == "PLN")
                    {
                        result = converter.ConvertToPLN(amount);
                        Console.WriteLine($"{amount} UAH = {result} PLN");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong, please check the text you entered");
                    }
                }
                else if (choice == "Another")
                {
                    Console.Write("Choose currency (USD, EUR, PLN): ");
                    string currency = Console.ReadLine();
                    Console.Write($"Enter the amount in {currency}: ");
                    double amount = double.Parse(Console.ReadLine());

                    double result = 0.0;
                    if (currency == "USD")
                    {
                        result = converter.ConvertFromUSD(amount);
                        Console.WriteLine($"{amount} USD = {result} UAH");
                    }
                    else if (currency == "EUR")
                    {
                        result = converter.ConvertFromEUR(amount);
                        Console.WriteLine($"{amount} EUR = {result} UAH");
                    }
                    else if (currency == "PLN")
                    {
                        result = converter.ConvertFromPLN(amount);
                        Console.WriteLine($"{amount} PLN = {result} UAH");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong, please check the text you entered");
                    }
                }
                else if (choice == "Exit")
                {
                    Console.WriteLine("You have exited, the program has been terminated");
                    break;
                }
                else
                {
                    Console.WriteLine("Something went wrong, please check the text you entered");
                }
            }
        }
    }
}
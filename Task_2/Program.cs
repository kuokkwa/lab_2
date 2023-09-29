namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(37.0, 40.0, 9.0);
            Console.Write("UAH: ");
            double amountInUAH = ;
                                    
            Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToUSD(amountInUAH):F2} USD");
            Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToEUR(amountInUAH):F2} EUR");
            Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToPLN(amountInUAH):F2} PLN");
        }
    }
}
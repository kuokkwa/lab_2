namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "Index: 11111";
            address.Country = "Country: Ukraine";
            address.City = "City: Kyiv";
            address.Street = "Street: Khreshchatyk";
            address.House = "House: none";
            address.Apartment = "Apartment: 11";
            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);

        }
    }
}
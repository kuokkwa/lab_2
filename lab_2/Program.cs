namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "11111";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Khreshchatyk";
            address.House = "none";
            address.Apartment = "11";
            Console.WriteLine("Index: {0}, \nCountry: {1}, \nCity: {2}, \nStreet: {3}, \nHouse: {4}, \nApartment: {5}", address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);
            Console.ReadKey();

        }
    }
}
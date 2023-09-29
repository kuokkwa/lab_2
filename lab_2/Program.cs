namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            int index = address.Index();
            string country = address.Country();
            string city = address.City();
            string street = address.Street();
            string house = address.House();
            int apartment = address.Apartment();
            Console.WriteLine(index);
            Console.WriteLine(country);
            Console.WriteLine(city);
            Console.WriteLine(street);
            Console.WriteLine(house);
            Console.WriteLine(apartment);

        }
    }
}
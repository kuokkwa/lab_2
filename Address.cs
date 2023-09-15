using System;

namespace Classes
{
    public class Address
    {
        static void Main(string[] args)
        {
        public int index;
        public string country;
        public string city;
        public string street;
        public string house;
        public string apartment;

        public Address()
        {
            index = 11111;
            country = "Ukraine";
            city = "Kyiv";
            street = "Khreshchatyk";
            house = "A1";
            apartment = "a123";
        }

        public void Print()
        {
            Console.WriteLine($"Index:{index}, Country:{country}, City:{city}, Street:{street}, House:{house}, Apartment:{apartment}");
        }
    }
}
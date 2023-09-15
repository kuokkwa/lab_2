using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Address
    {
        public class Credentials
        {
            public int index = 11111;
            public string country = "Ukraine";
            public string city = "Kyiv";
            public string street = "Khreshchatyk";
            public string house = "A1";
            public string apartment = "a123";
            static void Main(string[] args)
            {
                Console.WriteLine(value: $"Index:{index}, Country:{country}, City:{city}, Street:{street}, House:{house}, apartment:{apartment}");
            }
        }
    }
}
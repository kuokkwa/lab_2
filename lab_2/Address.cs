using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Address
    {
        private int index;

        private void getindex()
        {
            index = 11111;
        }

        public int Index()
        {
            return index;
        }

        private string country;

        private void getcountry()
        {
            country = "Ukraine";
        }

        public string Country()
        {
            return country;
        }

        private string city;

        private void getcity()
        {
            city = "Kyiv";
        }

        public string City()
        {
            return city;
        }

        private string street;

        private void getstreet()
        {
            street = "Khreshchatyk";
        } 

        public string Street()
        {
            return street;
        }

        private string house;

        private void gethouse()
        {
            house = "none";
        }

        public string House()
        {
            return house;
        }

        private int apartment;

        private void getapartment()
        {
            apartment = 11;
        }

        public int Apartment()
        {
            return apartment;
        }
    }
}

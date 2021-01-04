using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformation
{
    public class StudentAddress
    {
       public string address { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public StudentAddress()
        {
            address = "4";
            street = "Podvis";
            city = "Varna";
            country = "Bulgaria";
        }
        public StudentAddress(string address, string street, string city, string country)
        {
            this.address = address;
            this.street = street;
            this.city = city;
            this.country = country;
        }
        public void FullAddress()
        {
            Console.WriteLine("The address is {0},{1},{2},{3}", address, street, city, country);
        }
    }
}

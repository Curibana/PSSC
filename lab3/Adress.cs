using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab3
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address(string street, string city, string state, string postalCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public bool IsValid()
        {
            //număr stradă, numele străzii, orașul, codul poștal 
            string addressString = $"{Street}, {City}, {State} {PostalCode}, {Country}";
            string pattern = @"^\d+ \w+, \w+, \d{5}$";
            return Regex.IsMatch(addressString, pattern);
        }


        public override string ToString()
        {
            return $"{Street}, {City}, {State} {PostalCode}, {Country}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal class DeliveryAddress
    {
        public string? city;
        public string? street;
        public int? buildingNumber;

        public DeliveryAddress(string? City, String? Street, int? BuildingNumber)
        {
            city = City;
            street = Street;
            buildingNumber = BuildingNumber;
        }

        public void GetFullAddress()
        {
            Console.WriteLine($"{buildingNumber} {street} , {city}");
        }

        public override string ToString()
        {
            return $"{buildingNumber} {street} , {city}";
        }
    }
}

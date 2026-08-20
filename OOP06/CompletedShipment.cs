using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
       string trackingCode,
       string description,
       double weight,
       decimal deliveryFee,
       DeliveryAddress destination)
       : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }
}

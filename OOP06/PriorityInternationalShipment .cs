using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
        string trackingCode,
        string description,
        double weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal customsFee,
        string destinationCountry)
        : base(trackingCode, description, weight, deliveryFee,
               destination, customsFee, destinationCountry)
        {


        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority Customs Report");
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Priority International Shipment");
            base.PrintShipment();
        }
    }
}

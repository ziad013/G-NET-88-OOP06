using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP06
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("DestinationCountry is required");
                }
                destinationCountry = value;
            }
        }



        private decimal customsFee;

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        private decimal estimatedCost;
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
        }



        public InternationalShipment(string trackingCode, string description, double weight,
           decimal deliveryFee, DeliveryAddress destination, decimal customsFee, string destinationCountry) : base(trackingCode, description, weight,
              deliveryFee, destination)
        {
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;
            Name = "International Shipment";
        }



        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------International Shipment----------------");
            Console.WriteLine();
            base.PrintShipment();
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("International Customs Report");
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH003 has been Delivered.\n";
        }

        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost;
        }
    }
}

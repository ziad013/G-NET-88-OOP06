using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP06
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {

        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        private decimal estimatedCost;
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
        }



        public ExpressShipment(string trackingCode, string description, double weight,
            decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight,
               deliveryFee, destination)
        {
            ExtraFee = extraFee;
            Name = "Express Shipment";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------Express Shipment----------------");
            Console.WriteLine();
            base.PrintShipment();
            Console.WriteLine($"Express Fee: {extraFee}");
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH002 is Out for Delivery.\n";
        }

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }
    }
}

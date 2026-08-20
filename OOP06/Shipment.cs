using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal partial class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public static int TotalShipmentsCreated;

        public Shipment()
        {
            
        }


        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public string Name { get; set; }
        public Shipment(string trackingCode, string description, double weight,
                decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, default)
        {
            this.trackingCode = trackingCode;
          
        }
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("TrackingCode is required");
                }
                trackingCode = value;

            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }

        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }

        }

        public virtual decimal EstimatedCost { get => DeliveryFee + (decimal)(Weight * 5); }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0) { deliveryFee = newFee; }
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }


        public void weightUpdate(double newWeight)
        {
            weight = newWeight;
        }

        public void weightUpdate(double newWeight, double packingWeight)
        {
            weight = newWeight + packingWeight;
        }

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                Destination.city,
                Destination.street,
                Destination.buildingNumber
            );

            return copy;
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }


        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}

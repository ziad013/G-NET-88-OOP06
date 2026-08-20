using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal class DeliveryCenter
    {
        private string CenterName;
        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        public Shipment this[int position]
        {
            get
            {
                if (position >= 0 && position < shipments.Length)
                {
                    return shipments[position];
                }
                else
                {
                    return default;
                }
            }
            set
            {
                if (position >= 0 && position < shipments.Length)
                {
                    shipments[position] = value;
                }

            }
        }


        public Shipment this[string TrackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == TrackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }
        }

        private string driver;

        public string Driver
        {
            get { return driver; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Driver Name Is Required");
                }

                driver = value;
            }
        }


        private int count;
        public bool AddShipment(Shipment shipment)
        {
            if (count >= shipments.Length)
                return false;

            shipments[count] = shipment;
            count++;
            return true;

        }


        public bool RemoveShipment(string TrackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == TrackingCode)
                {
                    shipments[i] = null!;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {


            foreach (Shipment s in shipments)
            {
                s?.PrintShipment();
            }

        }



        public void PrintTrackingStatuses(ITrackable[] Items)
        {
            foreach (ITrackable t in Items)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }
        }


        public void printIInsurableCosts(ITrackable[] Items)
        {
            foreach (IInsurable t in Items)
            {
                Shipment shipment = (Shipment)t;

                Console.WriteLine($"{shipment.Name} Insurance : {t.CalculateInsurance()} \n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.TrackingStatus}";

        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}

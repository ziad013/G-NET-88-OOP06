using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    internal partial class Shipment
    {
        private string trackingStatus;

        public string TrackingStatus
        {
            get { return trackingStatus; }
             set
            {
                trackingStatus = value;
            }
        }

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;
            }
            OnTrackingStatusChanged(newStatus);
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}

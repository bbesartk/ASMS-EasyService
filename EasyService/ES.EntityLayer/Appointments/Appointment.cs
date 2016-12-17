using ES.EntityLayer.Vehicle;
using System;


namespace ES.EntityLayer.Appointments
{
    public enum ServiceType
    {
        SmallService,
        MajorService
    }
    public class Appointment
    {
        public string Subject { get; set; }

        public DateTime TimeOfMeeting { get; set; }

        public int SlotRowNumber { get; set; }

        public ServiceType ServiceType { get; set; }

        public Vehicle.Vehicle Vehicle { get; set; }

        public bool IsTreated { get; set; }


        public Appointment(string subject, DateTime timeOfMeeting, int slotRowNumber, ServiceType serviceType, Vehicle.Vehicle vehicle)
        {
            Subject = subject;
            TimeOfMeeting = timeOfMeeting;
            SlotRowNumber = slotRowNumber;
            Vehicle = vehicle;
            IsTreated = false;
        }
    }
}

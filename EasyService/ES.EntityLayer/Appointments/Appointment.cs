using System;


namespace ES.EntityLayer.Appointments
{
    public class Appointment
    {
        public string Subject { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int StartTime { get; set; }

        public int EndtTime { get; set; }

        public int SlotNumber { get; set; }

        public string ServiceType { get; set; }

        public Vehicle.Vehicle Vehicle { get; set; }

        public bool IsTreated { get; set; }

        public bool IsCanceled { get; set; }

        public int[] HoursOfAppointment { get { return AllHours(StartTime, EndtTime); } }
        


        public Appointment(string subject, DateTime appointmentDate, string serviceType, int startTime, int endTime, int slotNumber, Vehicle.Vehicle vehicle)
        {
            Subject = subject;
            AppointmentDate = appointmentDate;
            ServiceType = serviceType;
            StartTime = startTime;
            EndtTime = endTime;
            SlotNumber = slotNumber;
            Vehicle = vehicle;
            IsTreated = false;
            IsCanceled = false;
        }

        public int[] AllHours(int start, int end)
        {
            int[] allH = new int[end - start];
            for (int i = start; i < end; i++)
            {
                allH[i - start] = i;
            }

            return allH;
        }
    }
}

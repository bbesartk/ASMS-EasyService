using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;

namespace ES.DataAccessLayer
{
    public class dalAppointments
    {
        private static List<Appointment> _listOfAppointmens = new List<Appointment>();

        public static void Insert(Appointment appointment)
        {
            _listOfAppointmens.Add(appointment);
        }

        
        public static void Update(Appointment appointment)
        {
            foreach (Appointment oldAppointment in _listOfAppointmens)
            {
                if (appointment.IsPending == oldAppointment.IsPending)
                {
                    oldAppointment.IsPending = appointment.IsPending;
                    oldAppointment.IsTreated = appointment.IsTreated;
                }
            }
        }


        public static Appointment GetAppointment(string licensePlate)
        {
            foreach (Appointment appointment in _listOfAppointmens)
            {
                if (appointment.Vehicle.LicensePlate == licensePlate)
                    return appointment;
            }
            return null;
        }

        public static void Remove(string id)
        {
            Appointment appointment = GetAppointment(id);
            _listOfAppointmens.Remove(appointment);
        }
        public static List<Appointment> GetAll()
        {
            return _listOfAppointmens;
        }
    }
}

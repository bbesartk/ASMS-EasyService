using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;

namespace ES.DataAccessLayer
{
    class dalAppointments
    {
        private static List<Appointment> _listOfAppointmens = new List<Appointment>();

        public static void Insert(Appointment appointment)
        {
            _listOfAppointmens.Add(appointment);
        }

        public static void GetAppointment(string name)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Vehicles;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalAppointments
    {
        private static List<Appointment> ListOfAppointments = new List<Appointment>();

        public static void Insert(Appointment appointment)
        {
            ListOfAppointments.Add(appointment);
        }

        public static void Delete(Appointment appointment)
        {
            ListOfAppointments.Remove(appointment);
        }


        public static List<Appointment> GetAll()
        {
            return ListOfAppointments;
        }

        
    }
}

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

        public static List<Appointment> GetAllPending()
        {
            List<Appointment> pendingAppointments = new List<Appointment>();
            foreach (Appointment ap in ListOfAppointments)
            {
                if(ap.IsPending==true && ap.IsTreated==false)
                {
                    pendingAppointments.Add(ap);
                }
            }
            return pendingAppointments;
        }

        public static List<Appointment> GetAllTreated()
        {
            List<Appointment> treatedApp = new List<Appointment>();
            foreach (Appointment ap in ListOfAppointments)
            {
                if (ap.IsPending == false && ap.IsTreated == true)
                {
                    treatedApp.Add(ap);
                }
            }
            return treatedApp;
        }

        public static List<Appointment> GetAllAppointments()
        {
            List<Appointment> allapointmens = new List<Appointment>();
            foreach (Appointment ap in ListOfAppointments)
            {
                if (ap.IsPending == false && ap.IsTreated == false)
                {
                    allapointmens.Add(ap);
                }
            }
            return allapointmens;
        }


        
    }
}

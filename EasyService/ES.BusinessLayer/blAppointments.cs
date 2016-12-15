using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;
using ES.DataAccessLayer;


namespace ES.BusinessLayer
{
    public class blAppointments
    {
        #region CRUD
        public static void InsertAppointment(Appointment appointment)
        {
            if (appointment != null)
                dalAppointments.Insert(appointment);
            else throw new Exception("Invalid Appointment");
        }
        public static void UpdateAppointment(Appointment appointment)
        {
            if (appointment != null)
                dalAppointments.Update(appointment);
            else throw new Exception("Invalid Appointment");
        }

        public static void DeleteAppointment(string id)
        {
            if (id != "")
                dalAppointments.Remove(id);
            else throw new Exception("Invalid Id!");
        }
        public static Appointment GetAppointment(string id)
        {
            return dalAppointments.GetAppointment(id);
        }


        #endregion

        #region Query
        public static List<Appointment> GetAllAppointment()
        {
            return dalAppointments.GetAll();
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;
using ES.DataAccessLayer;
using ES.EntityLayer.General;

namespace ES.BusinessLayer
{
    public class blAppointments
    {
        #region CRUD
        //public static void InsertAppointment(Appointment appointment)
        //{
        //    if (appointment != null)
        //        dalAppointments.Insert(appointment);
        //    else throw new Exception("Invalid Appointment");
        //}
        //public static void UpdateAppointment(Appointment appointment)
        //{
        //    if (appointment != null)
        //        dalAppointments.Update(appointment);
        //    else throw new Exception("Invalid Appointment");
        //}

        //public static void DeleteAppointment(string id)
        //{
        //    if (id != "")
        //        dalAppointments.Remove(id);
        //    else throw new Exception("Invalid Id!");
        //}
        //public static Appointment GetAppointment(string id)
        //{
        //    return dalAppointments.GetAppointment(id);
        //}


        //#endregion

        //#region Query
        public static List<Appointment> GetAllAppointment()
        {
            return dalAppointments.GetAll();
        }

        public static bool HasValidTime(string serviceType, int meetingHour, int endTime)
        {
            if (serviceType == "Small Service")
            {
                if (meetingHour + 1 > endTime)
                    return false;
            }
            else if (serviceType == "Major Service")
            {
                if (meetingHour + 3 > endTime)
                    return false;
            }
            return true;
        }


        public static List<Slot> AvailableSlots(DateTime timeOfAppointment, string serviceType, int slotRowNumber, int endTime, List<Slot> allSlots)
        {

            bool[] array = new bool[allSlots.Count];
            List<Slot> availableSlots = new List<Slot>();

            if (HasValidTime(serviceType, timeOfAppointment.Hour, endTime))
            {
                foreach (var item in GetAllAppointment())
                {
                    if (DateTime.Equals(item.TimeOfMeeting,timeOfAppointment))
                    {
                        array[item.SlotRowNumber - 1] = true;

                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==false)
                {
                    availableSlots.Add(allSlots[i]);
                }
            }
            return availableSlots;
        }

        static DateTime d1 = new DateTime(2016, 12, 16, 11, 0, 0,0,0);

        public static void ListaApointment()
        {


            dalAppointments.Insert(new Appointment("dsadas", d1, 1, ServiceType.SmallService, null));
            dalAppointments.Insert(new Appointment("dsadas", d1, 2, ServiceType.SmallService, null));
        }

        #endregion


    }
}

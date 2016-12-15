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


        public static List<Slot> AvailableSlots(DateTime timeOfAppointment, string serviceType, int slotRowNumber,int endTime, List<Slot> allSlots)
        {
            List<Slot> freeSlots = new List<Slot>();
            foreach (var item in GetAllAppointment())
            {
                if(timeOfAppointment.Date==item.TimeOfMeeting.Date)
                {
                    if(HasValidTime(serviceType,timeOfAppointment.Hour,endTime))
                    {
                        for (int i = 0; i < allSlots.Count; i++)
                        {
                            if(slotRowNumber != allSlots[i].RowNumber)
                            {
                                freeSlots.Add(allSlots[i]);
                            }
                        }
                    }
                }
            }

            return freeSlots;
        }

        
        #endregion


    }
}

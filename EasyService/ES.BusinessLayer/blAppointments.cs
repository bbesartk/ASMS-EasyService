using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;
using ES.DataAccessLayer;
using ES.EntityLayer.General;
using ES.EntityLayer.Vehicle;

namespace ES.BusinessLayer
{
    public class blAppointments
    {
        #region CRUD

        #endregion

        #region Query
        public static List<Appointment> GetAllAppointment()
        {
            return dalAppointments.GetAll();
        }


        private static bool IsOnBreakTime(DateTime appointment,int startBreak, int difference)
        {
            for (int i = 0; i < difference; i++)
            {
                if (appointment.Hour == startBreak + i)
                    return true;
            }
            return false;
        }

        private bool HasAnotherAppointmentToday(Vehicle vehicle)
        {
            foreach (var item in GetAllAppointmentsByDate(DateTime.Now.Date))
            {
                if (item.Vehicle == vehicle)
                    return true;
            }
            return false;
        }

        public void UpdateAppointment(Appointment oldApp, Appointment newApp)
        {
            oldApp = newApp;            
        }


        private List<Appointment> GetAllAppointmentsByDate(DateTime dt)
        {
            List<Appointment> lista = new List<Appointment>();
            foreach (var item in GetAllAppointment())
            {
                if(item.AppointmentDate==dt.Date)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

        public static bool IsSundayActivated(bool sunday)
        {
            return sunday;
        }

        public static bool IsSaturdayActivated(bool saturday)
        {
            return saturday;
        }

        private static double GetDifference(double start, double end)
        {
            return end - start;
        }

        private static void AppointmentWithBreak(Appointment app, double difference)
        {
            app.EndtTime += (int)difference;
        }

        public static List<Appointment> GetAllNotTreated()
        {
            List<Appointment> lista = new List<Appointment>();

            foreach (var item in GetAllAppointment())
            {

                if(item.IsTreated==false)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

        public static bool HasValidTime(string serviceType, int meetingHour, int endWorkingTime)
        {
            if (serviceType == "Small Service")
            {
                if (meetingHour + 1 > endWorkingTime)
                    return false;
            }
            else if (serviceType == "Major Service")
            {
                if (meetingHour + 3 > endWorkingTime)
                    return false;
            }
            return true;
        }


        public static List<Slot> GetAvailableSlots(DateTime appointmentTime,string typeOfService, int sllotRownNumber, bool sunday, bool saturday, double startBreak, double endBreak, double startTime, double endTime)
        {
            List<Slot> list = new List<Slot>();
           
            return list;
        }


        public static List<Slot> AvailableSlots(DateTime timeOfAppointment, string serviceType, int slotRowNumber, int endWork, List<Slot> allSlots)
        {

            bool[] array = new bool[allSlots.Count];
            List<Slot> availableSlots = new List<Slot>();

            if (HasValidTime(serviceType, timeOfAppointment.Hour, endWork))
            {
                foreach (var item in GetAllAppointment())
                {
                    if (DateTime.Equals(item.AppointmentDate, timeOfAppointment))
                    {
                        array[item.SlotNumber - 1] = true;
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


        public static List<string> AvailableTime(DateTime timeOfAppointment, string serviceType, int slotNumber, int endWorkingTime, List<string> freeTimes)
        {
            List<string> availableTime = new List<string>();
            FillList(availableTime, freeTimes);

            if (HasValidTime(serviceType, timeOfAppointment.Hour, endWorkingTime))
            {
                List<Appointment> lista = AllSlotAppointmentsByDate(timeOfAppointment.Date, slotNumber);
                foreach (var item in lista)
                {
                    for (int i = 0; i < item.HoursOfAppointment.Length; i++)
                    {
                        string ora = item.HoursOfAppointment[i].ToString()+":00";
                        foreach (var hour in availableTime)
                        {
                            if (ora == hour)
                                availableTime.Remove(hour);
                        }

                    }
                }
            }

            return availableTime;
        }

        private static List<Appointment> AllSlotAppointmentsByDate(DateTime date, int slotNumber)
        {
            List<Appointment> lista = new List<Appointment>();
            foreach (var item in GetAllAppointment())
            {
                if((DateTime.Equals(date.Date,item.AppointmentDate.Date) && item.SlotNumber==slotNumber))
                {
                    lista.Add(item);
                }
            }

            return lista;
        }


        static DateTime d1 = new DateTime(2016, 12, 17, 11, 0, 0,0,0);

        public static void FillList(List<string> arrayToFill, List<string> source)
        {
            for (int i = 0; i < source.Count; i++)
            {
                arrayToFill.Add(source[i]);
            }
        }


        public static bool IsValid(DateTime appointment,int startWork, int endWork, bool saturday, bool sunday)
        { 
                if ((appointment.Date == DateTime.Now.Date) && (appointment.TimeOfDay < DateTime.Now.TimeOfDay))
                    throw new Exception("You have chosen a negative appointment!");
                else if (appointment.Hour < startWork || appointment.Hour > endWork)
                    throw new Exception("Outside the working hours!");
                else if ((saturday==false && appointment.DayOfWeek == DayOfWeek.Saturday) || (sunday == false && appointment.DayOfWeek == DayOfWeek.Sunday))
                    throw new Exception("Weekend!");
                else
                    return true;

        }

        public static void MakeTreated(Appointment appointment)
        {
            appointment.IsTreated = true;
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Autos;
using EasyService.DataAccess;
namespace EasyService.Appointments
{
    class Appointment
    {
        #region PrivateMembers
        private Vehicle _vehicle;
        private DateTime _appointment;
        #endregion

        #region Properties
        public DateTime DateOfMeeting
        {
            get
            {
                return _appointment;
            }
            set
            {
                if (IsValidAppointment(value)==true)
                    _appointment = value;
                else throw new Exception("This appointment is taken");
            }
        }
        public Vehicle Vehicle
        {
            get { return _vehicle; }
            set
            {
                if (IsPending == false) _vehicle = value;
                else
                {
                    throw new Exception("While pending you cant have an appointment!");
                }
            }

        }

        public bool IsPending { get; private set; }

        public string Description { get; private set; }


        #endregion



        #region Constructors

        public Appointment()
        {

        }
        public Appointment(DateTime dateOfMeeting, Vehicle vehicle)
        {
            DateOfMeeting = dateOfMeeting;
            Vehicle = vehicle;
            IsPending = false;
        }

        public Appointment(string description)
        {
            IsPending = true;
            Description = description;
        }
        #endregion

        #region Methods
        private bool IsValidAppointment(DateTime appointment)
        {
            if ((appointment.Date==DateTime.Now.Date) &&(appointment.TimeOfDay < DateTime.Now.TimeOfDay))
                throw new Exception("Kerkuat termin negativ!");
            else if (appointment.Hour < 8 || appointment.Hour > 17)
                throw new Exception("Jasht orarit te punes!");
            else if ((appointment.DayOfWeek == DayOfWeek.Saturday) || (appointment.DayOfWeek == DayOfWeek.Sunday))
                throw new Exception("Dite e vikendit!");
            else
            {
                foreach (Appointment item in daAppointments.ListAppointments)
                {
                    if ((item.DateOfMeeting.TimeOfDay == appointment.TimeOfDay))
                        return false;
                }
                return true;
            }
        }


        #endregion
    }
}

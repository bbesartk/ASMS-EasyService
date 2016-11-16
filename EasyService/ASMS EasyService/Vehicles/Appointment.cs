using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.DataAccess_Layer;

namespace ASMS_EasyService.Vehicles
{
    class Appointment
    {
        #region StaticMembers

        #endregion

        #region PrivateMembers
        private DateTime _dateOfAppointment;
        private string _description;
        private bool _ispending;
        private bool _istreated;
        #endregion

        #region Properties
        public bool IsPending {
        get
            {
                return _ispending;
            }
            set
            {
                if (IsTreated == false)
                    _ispending = value;
                else throw new Exception("You can not have a treated appoinment Pending!");
            }
        }

        public bool IsTreated
        {
            get { return _istreated; }
            set {if (IsPending == false)
                    _istreated = value;
                else throw new Exception("You can not treat a appointment while is pending!");
            }
        }

        public Vehicle Vehicle{ get;}

        public string Description
        {
            get { return _description; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a description! for pending");
                else _description = value;
            }
        }

        public DateTime DateOfAppointment
        {
            get { return _dateOfAppointment; }

            set
            {
                if (IsValidAppointment(value))
                    _dateOfAppointment = value;
                else throw new Exception("This appointment is taken");
            }
        }
        #endregion

        #region Constructors
        public Appointment(DateTime dateOfAppointment, Vehicle vehicle)
        {
            DateOfAppointment = dateOfAppointment;
            Vehicle = vehicle;
            IsPending = false;
            IsTreated = false;
        }

        public Appointment(string description)
        {
            IsPending = true;
            Description = description;
            IsTreated = false;
        }
        #endregion

        #region Methods
        private bool IsValidAppointment(DateTime appointment)
        {
            if ((appointment.Date == DateTime.Now.Date) && (appointment.TimeOfDay < DateTime.Now.TimeOfDay))
                throw new Exception("You have chosen a negative appointment!");
            else if (appointment.Hour < 8 || appointment.Hour > 17)
                throw new Exception("Outside the working hours!");
            else if ((appointment.DayOfWeek == DayOfWeek.Saturday) || (appointment.DayOfWeek == DayOfWeek.Sunday))
                throw new Exception("Weekend!");
            else
            {
                foreach (Appointment appoointment in dalAppointments.GetAll())
                {
                    if ((appoointment.DateOfAppointment.TimeOfDay == appointment.TimeOfDay))
                        return false;
                }
                return true;
            }
        }

        public void UpdateTreat(bool value)
        {
            IsTreated = value;
        }
        #endregion

    }
}

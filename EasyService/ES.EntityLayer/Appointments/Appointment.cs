using System;

namespace ES.EntityLayer.Appointments
{
    public class Appointment
    {
        #region PrivateMembers
        private DateTime _dateOfAppointment;
        private string _description;
        private bool _ispending;
        private bool _istreated;
        #endregion

        #region Properties
        public bool IsPending
        {
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
            set
            {
                if (IsPending == false)
                    _istreated = value;
                else throw new Exception("You can not treat a appointment while is pending!");
            }
        }

        public Vehicle.Vehicle Vehicle { get; }

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
                if (value != null)
                    _dateOfAppointment = value;
            }
        }
        #endregion

        #region Constructors
        public Appointment(DateTime dateOfAppointment, Vehicle.Vehicle vehicle)
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
    }
}

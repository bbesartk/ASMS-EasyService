using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Autos;

namespace EasyService.Appointments
{
    class Appointment
    {
        #region PrivateMembers
        private Vehicle _vehicle;
        #endregion

        #region Properties
        public DateTime DateOfMeeting { get; set; }

        public Vehicle Vehicle
        {
            get {return _vehicle;}
            set {if (IsPending == false)  _vehicle = value;}
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

        public Appointment(bool isPending, string description)
        {
            IsPending = isPending;

        }
        #endregion
    }
}

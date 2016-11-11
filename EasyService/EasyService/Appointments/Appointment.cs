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
        #region Properties
        public DateTime DateOfMeeting { get; set; }
        public  Vehicle Vehicle { get; set; }
        public bool IsTreated { get; set; }
        #endregion

        #region Constructors

        public Appointment()
        {

        }
        public Appointment(DateTime dateOfMeeting,Vehicle vehicle,bool isTreated)
        {
            DateOfMeeting = dateOfMeeting;
            Vehicle = vehicle;
            IsTreated = isTreated;
        }
        #endregion
    }
}

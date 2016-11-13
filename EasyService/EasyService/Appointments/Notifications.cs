using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Appointments
{
    public enum TreatedResponse {SetAppointment, SetPending, Unsubscribe }

    class Notifications
    {
        #region Properties
        public TreatedResponse TreatedResponse { get; set; }
        public Appointment Appointment { get; set; }
        public string Description { get; set; }


        #endregion

        #region Constructors
        public Notifications()
        {

        }

        public Notifications(TreatedResponse tr, string description)
        {
            TreatedResponse = tr;
            Description = description;
        }
        public Notifications(Appointment appointment)
        {
            Appointment = appointment;
        }

        #endregion
        #region Methods


        #endregion
    }
}

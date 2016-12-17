using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Appointments;

namespace EasyService.UI
{
    public partial class UC_ViewAppointment : UserControl
    {
        private readonly Appointment _appointment;
        public UC_ViewAppointment(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;

        }

        private void UC_ViewAppointment_Load(object sender, EventArgs e)
        {
            txbDate.Text = _appointment.TimeOfMeeting.ToShortDateString();
            txbHour.Text = _appointment.TimeOfMeeting.Hour.ToString();
            txbLicensePlate.Text = _appointment.Vehicle.LicensePlate;
            txbModel.Text = _appointment.Vehicle.Model;
            txbType.Text = _appointment.Vehicle.Type;

            if(_appointment.Vehicle.Company==null)
            {
                txbOwner.Text = _appointment.Vehicle.Client.Name + " " + _appointment.Vehicle.Client.Lastname;
            }
            else
            {
                txbOwner.Text = _appointment.Vehicle.Company.CompanyName;
            }

            txbSlot.Text = _appointment.SlotRowNumber.ToString();

            txbSubject.Text = _appointment.Subject;
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            _appointment.IsTreated = true;
            UC_ViewVehicle vh = new UC_ViewVehicle(_appointment.Vehicle);
            this.Controls.Clear();
            this.Controls.Add(vh);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Appointments app = new UC_Appointments();
            this.Controls.Clear();
            this.Controls.Add(app);
        }
    }
}

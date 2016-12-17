using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.BusinessLayer;
using ES.EntityLayer.Appointments;

namespace EasyService.UI
{
    public partial class UC_Appointments : UserControl
    {
        

        public UC_Appointments()
        {
            InitializeComponent();
        }

        private void UC_Appointments_Load(object sender, EventArgs e)
        {
            dgAppointment.DataSource = blAppointments.GetAllAppointment();
        }

        private void dgAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Appointment app = (Appointment)dgAppointment.Rows[e.RowIndex].DataBoundItem;
            UC_ViewAppointment appointment = new UC_ViewAppointment(app);

            this.Controls.Clear();
            this.Controls.Add(appointment);
        }
    }
}

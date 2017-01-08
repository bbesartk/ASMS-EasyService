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
using ES.DataAccessLayer;

namespace EasyService.UI
{
    public partial class UC_Appointments : UserControl
    {    
        public UC_Appointments()
        {
            InitializeComponent();
            RefreshList();
        }

        private void UC_Appointments_Load(object sender, EventArgs e)
        {
            rbExistingClient.Checked = true;
            if (rbExistingClient.Checked == true)
            dgAppointment.DataSource = blAppointments.GetAllAppointmentByExistedClient();
        }

        private void dgAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbExistingClient.Checked)
            {
                Appointment app = (Appointment)dgAppointment.Rows[e.RowIndex].DataBoundItem;
                UC_ViewAppointment appointment = new UC_ViewAppointment(app);

                this.Controls.Clear();
                this.Controls.Add(appointment);
            }
            else if(rbExistingClient.Checked==false)
            {
                Appointment app = (Appointment)dgAppointment.Rows[e.RowIndex].DataBoundItem;
                this.Controls.Clear();
                UC_Dashboard db = new UC_Dashboard(null, app.Vehicle.LicensePlate);
                this.Controls.Add(db);
            }
        }

        private void immediateMediate_Click(object sender, EventArgs e)
        {
            using (AddAppointments nyApp = new AddAppointments())
            {
                //nese ka nevoj per ndrrim hapet forma i mbushim te dhanat edhe i ruajm ne listen siper 
                nyApp.ShowDialog();
                if (nyApp.DialogResult == DialogResult.OK)
                {
                    dalAppointments.Insert(nyApp.NewAppointment);

                }

            }
        }

        private void rbExistingClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewClient.Checked)
            {
                RefreshList();
                dgAppointment.DataSource = blAppointments.GetAllAppointmentByNewClients();
            }
            else if(rbExistingClient.Checked)
            {
                RefreshList();
                dgAppointment.DataSource = blAppointments.GetAllAppointmentByExistedClient();
            }
        }
        private void RefreshList()
        {
            dgAppointment.DataSource = null;
        }
    }

}

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
using ES.EntityLayer.Vehicle;
using ES.DataAccessLayer;

namespace EasyService.UI
{
    public partial class UC_Dashboard : UserControl
    {
        public bool? _getAll = false;
        public UC_Dashboard()
        {
            InitializeComponent();
            lblNotificiations.Visible = true;
            dgNotifications.Visible = true;
            ChangeScreenByInput(_getAll);

        }

        public UC_Dashboard(bool? getAll, string licensePlate)
        {
            InitializeComponent();
            _getAll = getAll;
            txbKerko.Text = licensePlate;
            ChangeScreenByInput(getAll);

        }

        public UC_Dashboard(bool? getAll)
        {
            InitializeComponent();
            _getAll = getAll;
            ChangeScreenByInput(getAll);
        }
        private void txbKerko_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbKerko.Text == "search for a car...")
            {
                txbKerko.Clear();
                txbKerko.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            ChangeScreenByInput(_getAll);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            bool hasCarOnIt = false;
            bool isTable = false;
            if (rbLicensePlate.Checked == true)
            {
                isTable = true;
                foreach (var item in blVehicle.GetAll())
                {
                    if (item.LicensePlate == txbKerko.Text)
                    {
                        hasCarOnIt = true;

                        ViewVehicle(item);
                    }
                }
            }
            else if (rbVIN.Checked == true)
            {
                isTable = false;
                foreach (var item in blVehicle.GetAll())
                {
                    if (item.Vin == txbKerko.Text)
                    {
                        hasCarOnIt = true;

                        ViewVehicle(item);
                    }
                }
            }
            if (hasCarOnIt == false)
            {
                DialogResult dr = MessageBox.Show("Vehicle not found! - do you want to register as new one?", "Vehicle not found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UC_RegVehicle car = new UC_RegVehicle(txbKerko.Text, isTable);
                    this.Controls.Clear();
                    this.Controls.Add(car);
                }
            }
        }

        private void ViewVehicle(Vehicle vh)
        {
            this.Controls.Clear();
            UC_ViewVehicle vehicle = new UC_ViewVehicle(vh);
            this.Controls.Add(vehicle);
        }

        private void dgNotifications_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vehicle vehicle = (Vehicle)dgNotifications.Rows[e.RowIndex].DataBoundItem;
            if (_getAll == true)
            {
                ViewVehicle(vehicle);
            }
            else
            {
                using (AddAppointments nyApp = new AddAppointments(vehicle))
                {
                    //nese ka nevoj per ndrrim hapet forma i mbushim te dhanat edhe i ruajm ne listen siper 
                    nyApp.ShowDialog();
                    if (nyApp.DialogResult == DialogResult.OK)
                    {
                        dalAppointments.Insert(nyApp.NewAppointment);

                    }

                }
            }
        }

        private void ChangeScreenByInput(bool? _getAll)
        {
            if (_getAll == true)
            {
                lblNotificiations.Text = "LIST OF ALL VEHICLES!";
                dgNotifications.DataSource = blVehicle.GetAll();
            }
            if (_getAll == false)
            {
                lblNotificiations.Text = "NOTIFICATIONS!";
                dgNotifications.DataSource = blVehicle.GeAllReadyForService();
            }
            if (_getAll == null)
            {
                lblNotificiations.Visible = false;
                dgNotifications.Visible = false;
            }
        }
    }
}

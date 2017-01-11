using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Vehicle;
using POO16F3;
using ES.EntityLayer.Finance;

namespace EasyService.UI
{
    public partial class UC_ViewServices : UserControl,IParaqit
    {
        private readonly Vehicle _vehicle;
        public UC_ViewServices(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void UC_ViewServices_Load(object sender, EventArgs e)
        {
            dgServices.DataSource = _vehicle.ServiceList;
            lblTotalS.Text += _vehicle.ServiceList.Count.ToString();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_ViewVehicle vehicle = new UC_ViewVehicle(_vehicle);
            this.Controls.Add(vehicle); 
        }

        public void Paraqit()
        {
            DialogResult dg = MessageBox.Show($"Service for vehicle with plate number: {_vehicle.LicensePlate}\r\nDO YOU WANT TO SEE DETAILS?");
            if(dg == DialogResult.Yes)
            {
                
            }
        }
    }
}

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
using ES.EntityLayer.General;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class UC_Vehicle : UserControl
    {
        public UC_Vehicle()
        {
            InitializeComponent();
            
        }

        private void txbVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbVehicle.Text == "search for a vehicle...")
            {
                txbVehicle.Clear();
                txbVehicle.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Vehicle allVehicle = new UC_Vehicle();
            this.Controls.Clear();
            this.Controls.Add(allVehicle);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {

        }

        private void UC_Vehicle_Load(object sender, EventArgs e)
        {
            dgVehicles.DataSource = blVehicle.GetAllSubscribed();
        }
    }
}

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
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class UC_RegVehicle : UserControl
    {
        public readonly string _tableOrVin;
        public readonly Vehicle _vehicle;

        public UC_RegVehicle(string tableOrVin,bool isTable)
        {
            InitializeComponent();
            _tableOrVin = tableOrVin;
            //to fill textbox
            if (isTable)
            {
                txbLicensePlate.Text = tableOrVin;
            }
            else txbVin.Text = tableOrVin;
        }

        public UC_RegVehicle(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void txb_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "write...")
            {
                txt.Clear();
                txt.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (rbClient.Checked == true)
                {
                    
                    UC_EditClient newClient = new UC_EditClient(new Vehicle(txbLicensePlate.Text, txbVin.Text, int.Parse(txbProductYear.Text), txbType.Text, txbModel.Text, int.Parse(txbCubic.Text)));
                    panelClient.Visible = true;
                    panelClient.Controls.Clear();
                    panelClient.Controls.Add(newClient);
                }
                else if (rbCompany.Checked == true)
                {
                    UC_EditCompany newCompany = new UC_EditCompany(new Vehicle(txbLicensePlate.Text, txbVin.Text, int.Parse(txbProductYear.Text), txbType.Text, txbModel.Text, int.Parse(txbCubic.Text)));
                    panelClient.Visible = true;
                    panelClient.Controls.Clear();                  
                    panelClient.Controls.Add(newCompany);
                }
            }
            catch
            {
                MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        
    }
}

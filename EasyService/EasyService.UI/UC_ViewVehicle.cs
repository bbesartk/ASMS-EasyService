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

namespace EasyService.UI
{
    public partial class UC_ViewVehicle : UserControl
    {
        private readonly Vehicle _vehicle;
        public UC_ViewVehicle(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
            ReadVehicle(_vehicle, true);
        }

        private void UC_ViewVehicle_Load(object sender, EventArgs e)
        {

            pBsmallService.Value = 10;
            pBmajorService.Value = 78;
        }


        private void ReadVehicle(Vehicle vehicle, bool readOnly)
        {
            txbVin.Text = _vehicle.Vin;
            txbVin.ReadOnly = true;

            txbType.Text = _vehicle.Type.ToString();
            txbType.ReadOnly = readOnly;

            txbModel.Text = _vehicle.Model;
            txbModel.ReadOnly = readOnly;

            txbProductYear.Text = _vehicle.ProductionYear.ToString();
            txbProductYear.ReadOnly = readOnly;

            txbLicensePlate.Text = _vehicle.LicensePlate;
            txbLicensePlate.ReadOnly = readOnly;

            txbCubic.Text = _vehicle.CubicC.ToString();
            txbCubic.ReadOnly = readOnly;

        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            if(_vehicle.Client!=null && _vehicle.Company==null)
            {
                this.Controls.Clear();
                UC_EditClient client = new UC_EditClient(_vehicle.Client);
                this.Controls.Add(client);
            }
            else if(_vehicle.Client == null && _vehicle.Company != null)
            {
                this.Controls.Clear();
                UC_EditCompany company = new UC_EditCompany(_vehicle.Company);
                this.Controls.Add(company);
            }
            else
            {
                if(_vehicle.Client == null && _vehicle.Company == null)
                {
                    DialogResult dr = MessageBox.Show("This car has no owner!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            UC_ViewServices allServices = new UC_ViewServices(_vehicle);
            this.Controls.Clear();
            this.Controls.Add(allServices);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            UC_ServiceDetail sd = new UC_ServiceDetail(_vehicle);
            this.Controls.Clear();
            this.Controls.Add(sd);
        }
    }
}

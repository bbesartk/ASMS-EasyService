using ES.EntityLayer.Clients;
using ES.EntityLayer.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyService.UI
{
    public partial class NewClient : Form
    {
        public Vehicle Vehicle = new Vehicle();
        public NewClient()
        {
            InitializeComponent();

        }

        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            Client c1 = new Client();
            c1.Name = txtOwner.Text;

            Vehicle.Client = c1;
            Vehicle.Client.Name = txtOwner.Text;
            Vehicle.Type = txtType.Text;
            Vehicle.LicensePlate = txtPlate.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}


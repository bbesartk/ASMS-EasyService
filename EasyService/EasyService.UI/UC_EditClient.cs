using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Clients;
using ES.BusinessLayer;
using ES.EntityLayer.General;

namespace EasyService.UI
{
    public partial class UC_EditClient : UserControl
    {
        private readonly Client _client;
        public UC_EditClient(Client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void UC_EditClient_Load(object sender, EventArgs e)
        {
            ReadClient(_client, true);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "VALIDATE EDIT")
            {
                try
                {
                    var client = blClients.GetClient(int.Parse(txbId.Text));
                    blClients.UpdateClient(ChangeClientDetails(client));

                    CallPanel(2);
                }
                catch
                {
                    MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnEdit.Text == "EDIT THIS CLIENT")
            {
                btnEdit.Text = "VALIDATE EDIT";
                ReadClient(_client, false);
            }
        }

        private void CallPanel(int number)
        {
            switch (number)
            {
                case 1:
                    UC_Clients c1 = new UC_Clients();
                    this.Controls.Clear();
                    this.Controls.Add(c1);
                    break;
                case 2:
                    UC_PrivateClient pc = new UC_PrivateClient();
                    this.Controls.Clear();
                    this.Controls.Add(pc);
                    break;
            }
        }

        private Client ChangeClientDetails(Client client)
        {
            client.Id = int.Parse(txbId.Text);
            client.Name = txbName.Text;
            client.Lastname = txbLastName.Text;
            client.ContactInfo.Address = txbAddress.Text;
            client.ContactInfo.City = txbCity.Text;
            client.ContactInfo.PhoneNumber = txbPhoneNumber.Text;
            client.ContactInfo.Email = txbEmail.Text;
            return client;
        }

        private void ReadClient(Client client, bool readOnly)
        {
            txbId.Text = client.Id.ToString();
            txbId.ReadOnly = true;

            txbName.Text = client.Name;
            txbName.ReadOnly = readOnly;

            txbLastName.Text = client.Lastname;
            txbLastName.ReadOnly = readOnly;

            txbPhoneNumber.Text = client.ContactInfo.PhoneNumber;
            txbPhoneNumber.ReadOnly = readOnly;

            txbEmail.Text = client.ContactInfo.Email;
            txbEmail.ReadOnly = readOnly;

            txbAddress.Text = client.ContactInfo.Address;
            txbAddress.ReadOnly = readOnly;

            txbCity.Text = client.ContactInfo.City;
            txbCity.ReadOnly = readOnly;


        }

    }
}

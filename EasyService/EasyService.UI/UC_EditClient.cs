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
using ES.EntityLayer.Vehicle;

namespace EasyService.UI
{
    public partial class UC_EditClient : UserControl
    {
        private readonly Client _client;
        private readonly Vehicle _vehicle;

        public UC_EditClient(Client client)
        {
            //fro editing a client
            InitializeComponent();
            _client = client;
            ReadClient(_client, true);
        }

        public UC_EditClient(Vehicle vehicle)
        {
            //For inserting a new vehicle we need a owner!!!
            InitializeComponent();
            _vehicle = vehicle;
        }
        private void UC_EditClient_Load(object sender, EventArgs e)
        {
            if(_vehicle != null)
            {
                btnEdit.Text = "FINISH REGISTRATION";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CallPanel(2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_vehicle!=null)
            {
                if(blClients.GetClient(txbId.Text)!=null)
                {
                    _vehicle.Client = blClients.GetClient(txbId.Text);
                    blVehicle.InsertVehicle(_vehicle);
                }
                else if(blClients.GetClient(txbId.Text)==null)
                {
                    Client c1 = new Client(txbId.Text, txbName.Text, txbLastName.Text, new ContactInfo(txbCity.Text, txbAddress.Text, txbPhoneNumber.Text, txbEmail.Text));
                    blClients.InsertClient(c1);
                    _vehicle.Client = c1;
                    blVehicle.InsertVehicle(_vehicle);
                }
                
            }

            else if (_vehicle == null)
            {
                if (btnEdit.Text == "VALIDATE EDIT")
                {
                    try
                    {
                        blClients.UpdateClient(ChangeClientDetails(_client));

                        CallPanel(2);
                    }
                    catch
                    {
                        MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (btnEdit.Text == "EDIT THIS CLIENT")
                {
                    try
                    {
                        btnEdit.Text = "VALIDATE EDIT";
                        ReadClient(_client, false);
                    }
                    catch
                    {
                        MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
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
            client.Id = txbId.Text;
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


        private void txb_MouseClick(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "write...")
            {
                txt.Clear();
                txt.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }


        private void txbId_TextChanged(object sender, EventArgs e)
        {
            if (txbId.Text.Length == 10)
            {
                foreach (var client in blClients.GetAllClients())
                {
                    if(txbId.Text==client.Id)
                    {
                        FillText(client);
                    }
                }
            }

        }

        private void FillText(Client client)
        {
            txbName.Text = client.Name;
            txbLastName.Text = client.Lastname;
            txbEmail.Text = client.ContactInfo.Email;
            txbAddress.Text = client.ContactInfo.Address;
            txbPhoneNumber.Text = client.ContactInfo.PhoneNumber;
            txbCity.Text = client.ContactInfo.City;
        }
    }
}

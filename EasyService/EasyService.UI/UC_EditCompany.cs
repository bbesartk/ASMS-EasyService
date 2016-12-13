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

namespace EasyService.UI
{
    public partial class UC_EditCompany : UserControl
    {
        private readonly Company _company;
        public UC_EditCompany(Company company)
        {
            InitializeComponent();
            _company = company;
        }

        private void UC_Company_Load(object sender, EventArgs e)
        {
            ReadCompany(_company, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "VALIDATE EDIT")
            {
                try
                {
                    blCompany.UpdateCompany(ChangeCompanyDetails(_company));
                    CallPanel(2);
                }
                catch
                {
                    MessageBox.Show("Please fill the fields correctly!", "Invalid attempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnEdit.Text == "EDIT THIS COMPANY")
            {
                btnEdit.Text = "VALIDATE EDIT";
                ReadCompany(_company, false);

            }
        }

        private void CallPanel(int number)
        {
            switch (number)
            {
                case 1:
                    UC_Dashboard dash = new UC_Dashboard();
                    this.Controls.Clear();
                    this.Controls.Add(dash);
                    break;
                case 2:
                    UC_Company cc = new UC_Company();
                    this.Controls.Clear();
                    this.Controls.Add(cc);
                    break;
            }
        }


        private void ReadCompany(Company company, bool readOnly)
        {
            txbId.Text = company.BusinessNumber;
            txbId.ReadOnly = true;

            txbName.Text = company.CompanyName;
            txbName.ReadOnly = readOnly;

            txbPhoneNumber.Text = company.ContactInfo.PhoneNumber;
            txbPhoneNumber.ReadOnly = readOnly;

            txbEmail.Text = company.ContactInfo.Email;
            txbEmail.ReadOnly = readOnly;

            txbAddress.Text = company.ContactInfo.Address;
            txbAddress.ReadOnly = readOnly;

            txbCity.Text = company.ContactInfo.City;
            txbCity.ReadOnly = readOnly;
        }

        private Company ChangeCompanyDetails(Company company)
        {
            company.BusinessNumber = txbId.Text;
            company.CompanyName = txbName.Text;
            company.ContactInfo.Address = txbAddress.Text;
            company.ContactInfo.City = txbCity.Text;
            company.ContactInfo.PhoneNumber = txbPhoneNumber.Text;
            company.ContactInfo.Email = txbEmail.Text;
            return company;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Clients allClients = new UC_Clients();
            this.Controls.Clear();
            this.Controls.Add(allClients);
        }
    }
}

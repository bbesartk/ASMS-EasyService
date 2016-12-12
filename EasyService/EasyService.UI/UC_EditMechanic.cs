using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Employees;
using ES.BusinessLayer;


namespace EasyService.UI
{
    public partial class UC_EditMechanic : UserControl
    {
        private readonly Mechanic _mechanic;
        public UC_EditMechanic(Mechanic mechanic)
        {
            InitializeComponent();
            _mechanic = mechanic;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "VALIDATE EDIT")
            {
                try
                {
                    blEmployees.UpdateEmployees(ChangeMechanicDetails(_mechanic));
                    CallPanel(2);
                }
                catch 
                {

                    MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnEdit.Text == "EDIT THIS MECHANIC")
            {
                btnEdit.Text = "VALIDATE EDIT";
                ReadMechanic(_mechanic, false);
                
            }
        }
        private void CallPanel(int number)
        {
            switch (number)
            {
                case 1: UC_Staff s1 = new UC_Staff();
                    this.Controls.Clear();
                    this.Controls.Add(s1);
                    break;
                case 2: UC_Mechanic m1 = new UC_Mechanic();
                    this.Controls.Clear();
                    this.Controls.Add(m1);
                    break;
            }
        }
        private Mechanic ChangeMechanicDetails(Mechanic mechanic)
        {
            mechanic.Id = txbId.Text;
            mechanic.Name = txbName.Text;
            mechanic.Lastname = txbLastName.Text;
            mechanic.Username = txbUserName.Text;
            mechanic.Password = txbPassword.Text;
            mechanic.ContactInfo.City = txbCity.Text;
            mechanic.ContactInfo.Address = txbAddress.Text;
            mechanic.ContactInfo.Email = txbEmail.Text;
            mechanic.ContactInfo.PhoneNumber = txbPhoneNumber.Text;
            return mechanic;
        }
        private void ReadMechanic(Mechanic mechanic, bool readOnly)
        {
            txbId.Text = mechanic.Id.ToString();
            txbId.ReadOnly = true;

            txbName.Text = mechanic.Name.ToString();
            txbName.ReadOnly = readOnly;

            txbLastName.Text = mechanic.Lastname.ToString();
            txbLastName.ReadOnly = readOnly;

            txbUserName.Text = mechanic.Username.ToString();
            txbUserName.ReadOnly = readOnly;

            txbPassword.Text = mechanic.Password.ToString();
            txbPassword.ReadOnly = readOnly;

            txbCity.Text = mechanic.ContactInfo.City.ToString();
            txbCity.ReadOnly = readOnly;

            txbAddress.Text = mechanic.ContactInfo.Address.ToString();
            txbAddress.ReadOnly = readOnly;

            txbEmail.Text = mechanic.ContactInfo.Email.ToString();
            txbEmail.ReadOnly = readOnly;

            txbPhoneNumber.Text = mechanic.ContactInfo.PhoneNumber.ToString();
            txbPhoneNumber.ReadOnly = readOnly;

        }

        private void UC_EditMechanic_Load(object sender, EventArgs e)
        {
            ReadMechanic(_mechanic, true);
        }
    }
}

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
using ES.EntityLayer.Services;
using ES.EntityLayer.Stock;

namespace EasyService.UI
{
    public partial class UC_RegisterServiceName : UserControl
    {
        public UC_RegisterServiceName()
        {
            InitializeComponent();
        }

        private void UC_RegisterServiceName_Load(object sender, EventArgs e)
        {
            cmbItemCategory.DataSource = blStock.GetItemCategories();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbSeviceName.Text.Length > 10 && (cbxSmallService.Checked == true || cbxMajorService.Checked == true))
            {
                if (cbxNeedsReplacement.Checked)
                {
                    blServices.InsertNewServiceType(new ServiceName(txbSeviceName.Text, cbxMajorService.Checked, cbxSmallService.Checked, true, (Category)cmbItemCategory.SelectedItem));
                }
                else
                {
                    blServices.InsertNewServiceType(new ServiceName(txbSeviceName.Text, cbxMajorService.Checked, cbxSmallService.Checked));
                   
                }
                DialogResult dg = MessageBox.Show("Service Registred Successfully!", "Register New Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dg == DialogResult.OK)
                {
                    UC_Settings set = new UC_Settings();
                    this.Controls.Clear();
                    this.Controls.Add(set);
                }
            }
            else MessageBox.Show("Please fill the fields correctly!");
        }

        private void cbxNeedsReplacement_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNeedsReplacement.Checked)
                pnlReplace.Visible = true;
            else pnlReplace.Visible = false;
        }
    }
}

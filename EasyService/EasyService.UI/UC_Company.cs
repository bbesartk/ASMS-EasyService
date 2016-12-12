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
using ES.EntityLayer.Clients;

namespace EasyService.UI
{
    public partial class UC_Company : UserControl
    {
        public UC_Company()
        {
            InitializeComponent();
        }

        private void UC_Company_Load(object sender, EventArgs e)
        {
            dgCompany.DataSource = blCompany.GetAllCompanies();
        }

        private void dgCompany_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Company company = (Company)dgCompany.Rows[e.RowIndex].DataBoundItem;
            EditCompany(company);
        }

        private void EditCompany(Company company)
        {
            UC_EditCompany eCom = new UC_EditCompany(company);
            this.Controls.Clear();
            this.Controls.Add(eCom);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_Clients client = new UC_Clients();
            this.Controls.Add(client);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            var company = blCompany.GetCompany(txbKerko.Text);
            if (company != null)
            {
                EditCompany(company);
            }
            else MessageBox.Show("This Company doesn't exist!", "Invalid Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txbKerko_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbKerko.Text == "search for a company...")
            {
                txbKerko.Clear();
                txbKerko.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }
    }
}

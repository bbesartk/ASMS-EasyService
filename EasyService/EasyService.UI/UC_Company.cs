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

        private void dgCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

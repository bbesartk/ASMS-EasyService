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
using ES.DataAccessLayer;

namespace EasyService.UI
{
    public partial class UC_Reports : UserControl
    {
        public UC_Reports()
        {
            InitializeComponent();

            cmbService.DataSource = blEmployees.GetAllMechanics();
        }

        private void txb_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            lblAllIncomes.Text = blInvoice.GetAllIncomes().ToString();
            lblClients.Text = blClients.GetAllClients().Count.ToString();
            lblComp.Text = blCompany.GetAllCompanies().Count.ToString();
            lblEmp.Text = blEmployees.GetAllMechanics().Count.ToString();
            lblItems.Text = blStock.CountAllItems().ToString();

            
            lblThisYearIncomes.Text = blInvoice.GetThisYearIncomes().ToString();
            lblTodayIncomes.Text = blInvoice.GetTodayIncomes().ToString();
            lblVehicles.Text = blVehicle.GetAll().Count.ToString();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = blEmployees.GetAllMechanics()[cmbService.SelectedIndex];
            dgServiced.DataSource = blVehicle.ServicedBy(emp.Id);
            
        }
    }
}

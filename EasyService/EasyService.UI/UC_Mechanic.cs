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
    public partial class UC_Mechanic : UserControl
    {
        public UC_Mechanic()
        {
            InitializeComponent();
        }

        private void dgPrivateClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Mechanic mechanic = (Mechanic)dgMechanic.Rows[e.RowIndex].DataBoundItem;
            EditMechanic(mechanic);

        }

        private void EditMechanic(Mechanic mechanic)
        {
            UC_EditMechanic mech = new UC_EditMechanic(mechanic);
            this.Controls.Clear();
            this.Controls.Add(mech);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            var mechanic = blEmployees.GetMechanic(txbKerko.Text);
            if (mechanic != null)
            {
                EditMechanic(mechanic);
            }
            else MessageBox.Show("This Client doesnt exist!", "Invalid Client!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UC_Mechanic_Load(object sender, EventArgs e)
        {
            dgMechanic.DataSource = blEmployees.GetAllMechanics();
        }
    }
}

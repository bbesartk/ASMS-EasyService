using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyService.UI
{
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            UC_Mechanic mechanic = new UC_Mechanic();
            this.Controls.Clear();
            this.Controls.Add(mechanic);
        }
    }
}

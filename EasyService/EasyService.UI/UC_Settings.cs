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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
          
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_RegisterServiceName extraService = new UC_RegisterServiceName();
            this.Controls.Add(extraService);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_AppointmentValidation appset = new UC_AppointmentValidation();
            this.Controls.Add(appset);
        }
    }
}

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
    public partial class UC_Clients : UserControl
    {
        public UC_Clients()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            UC_PrivateClient clients = new UC_PrivateClient();
            this.Controls.Clear();
            this.Controls.Add(clients);
        }


    }
}

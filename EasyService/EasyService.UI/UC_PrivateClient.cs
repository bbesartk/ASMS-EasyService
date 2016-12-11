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
using ES.EntityLayer.General;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class UC_PrivateClient : UserControl
    {
        public UC_PrivateClient()
        {
            InitializeComponent();
            blClients.LotOfClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Clients allClients = new UC_Clients();
            this.Controls.Clear();
            this.Controls.Add(allClients);
        }

        private void txbKerko_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbKerko.Text == "search for a client...")
            {
                txbKerko.Clear();
                txbKerko.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            
        }

        private void dgNotifications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)dgPrivateClients.Rows[e.RowIndex].DataBoundItem;
            EditClient(client);
        }

        private void EditClient(Client client)
        {
            UC_EditClient eClient = new UC_EditClient(client);
            this.Controls.Clear();
            this.Controls.Add(eClient);
        }

        private void UC_PrivateClient_Load(object sender, EventArgs e)
        {
            dgPrivateClients.DataSource = blClients.GetAllClients();
        }


    }
}

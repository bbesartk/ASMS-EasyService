using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            UC_Stock stock = new UC_Stock();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(stock);
        }
    }
}

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
using ES.EntityLayer.General;

namespace EasyService.UI
{
    public partial class MainPage : Form
    {
        public static int StartTime { get; set; } = 7;
        public static int EndTime { get; set; } = 16;
        public static string Username { get; set; } = "easyservice";
        public static string Password { get; set; } = "password";

        public static int ActiveSlots { get; set; } = 4;

        public MainPage()
        {
            InitializeComponent();
            lblTime.Text += (DateTime.Now.Date).ToShortDateString();
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

        private void btnKlient_Click(object sender, EventArgs e)
        {
            UC_Clients clients = new UC_Clients();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(clients);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            UC_Staff staff = new UC_Staff();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard vh = new UC_Dashboard(true);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(vh);
        }

        private void btnRaports_Click(object sender, EventArgs e)
        {
            UC_Reports rep = new UC_Reports();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(rep);
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            UC_Settings settings = new UC_Settings();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(settings);
        }
    }
}

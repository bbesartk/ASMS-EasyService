using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASMS_EasyService.DataAccess_Layer;

namespace ASMS_EasyService
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txbKerko_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (txbKerko.Text == "search for a car...")
            {
                txbKerko.Clear();
                txbKerko.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChangeBg(btn, 50, 194, 221);
            btn.ForeColor = Color.FromArgb(44, 55, 59);
        }

        private void bnt_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChangeBg(btn, 44, 55, 59);
            btn.ForeColor = Color.FromArgb(50, 194, 221);
        }

        private void ChangeBg(Button btn,int r, int g, int b)
        {
            btn.BackColor = Color.FromArgb(r, g, b);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblTime.Text += DateTime.Now.DayOfWeek;
            dgNotifications.DataSource = null;

            Vehicles.Vehicle v1 = new Vehicles.Vehicle("rsrsfsf", 1994, "HG", "dsadsa", 4232);
            Vehicles.Vehicle v2 = new Vehicles.Vehicle("rsrsfsf", 24224, "aa", "dsadsa", 4232);
            dalVehicles.Insert(v1);
            dalVehicles.Insert(v2);
            dgNotifications.DataSource = dalVehicles.GetAllSubscribed();
            
        }
    }
}

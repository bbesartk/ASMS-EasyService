using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMS_EasyService
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblTime.Text += DateTime.Now.DayOfWeek;
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

        private void MainPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}

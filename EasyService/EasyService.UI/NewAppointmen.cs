using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyService.UI
{
    public partial class NewAppointmen : Form
    {
        public NewAppointmen()
        {
            InitializeComponent();
        }

        Button[] buttons = new Button[10];

        private void NewAppointmen_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now.Date;

        }

        private void txbSubject_MouseHover(object sender, EventArgs e)
        {
            txbSubject.Text = "//";
            txbSubject.ForeColor = Color.FromArgb(50, 194, 221);
            txbSubject.BackColor = Color.White;
        }

        private void txbSubject_MouseLeave(object sender, EventArgs e)
        {
            if (txbSubject.Text == "")
            {
                txbSubject.Text = " Appointment subject here";
            }
            txbSubject.ForeColor = Color.White;
            txbSubject.BackColor = Color.FromArgb(50, 194, 221);

        }

        private void txbSubject_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txbSubject_MouseClick(object sender, MouseEventArgs e)
        {
            txbSubject.Text = "";
        }

        }
    }
}

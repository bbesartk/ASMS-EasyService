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
    public partial class AddAppointments : Form
    {
        public AddAppointments()
        {
            InitializeComponent();
        }

        private void txtSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSubject.Text == "Appointment Subject...")
                txtSubject.Clear();
        }

        private void AddAppointments_Load(object sender, EventArgs e)
        {
            dtpMeeting.MinDate = DateTime.Now;
        }

    }
}

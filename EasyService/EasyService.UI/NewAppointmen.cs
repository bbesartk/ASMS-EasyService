using ES.EntityLayer.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.DataAccessLayer;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class NewAppointmen : Form
    {
        private readonly Vehicle _vehicle;
        private static string typeOfService;
        private static int slotNumber;
        public NewAppointmen(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
            blAppointments.ListaApointment();
        }

        private void NewAppointmen_Load(object sender, EventArgs e)
        {
            mcDate.MinDate = DateTime.Now.Date;
            cmbSlot.DataSource = dalSlot.SlotList();
            typeOfService = rbSmall.Checked ? rbSmall.Text : rbMajor.Text;


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

        private void button1_Click(object sender, EventArgs e)
        {
            string hour = cmbHour.Text.Split(':')[0];
            string minute = cmbHour.Text.Split(':')[1];
        }

        private void cmbHour_SelectedValueChanged(object sender, EventArgs e)
        {

            string hour = cmbHour.Text.Split(':')[0];
            string minute = cmbHour.Text.Split(':')[1];
            var dtTime = new DateTime(mcDate.SelectionRange.Start.Year, mcDate.SelectionRange.Start.Month, mcDate.SelectionRange.Start.Day, int.Parse(hour), int.Parse(minute), 0,0,0);
            cmbSlot.DataSource = blAppointments.AvailableSlots(dtTime, typeOfService, slotNumber, 17, dalSlot.SlotList());
        }

        private void chb_Checked(object sender, EventArgs e)
        {
            typeOfService = rbSmall.Checked ? rbSmall.Text : rbMajor.Text;
        }

        private void cmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
            slotNumber = dalSlot.GetSlotId(cmbSlot.Text);
        }

        private void mcDate_DateSelected(object sender, DateRangeEventArgs e)
        {
           //string data = mcDate.
        }
    }
}


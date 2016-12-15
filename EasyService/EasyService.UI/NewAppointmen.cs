﻿using ES.EntityLayer.Vehicle;
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
        private static int rowNumber;
        public NewAppointmen(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void NewAppointmen_Load(object sender, EventArgs e)
        {
            mcDate.MinDate = DateTime.Now.Date;
            cmbSlot.DataSource = dalSlot.AllSlots();

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

            MessageBox.Show(dtTime.ToString());
        }

        private void cmbHour_SelectedValueChanged(object sender, EventArgs e)
        {

            string hour = cmbHour.Text.Split(':')[0];
            string minute = cmbHour.Text.Split(':')[1];
            var dtTime = new DateTime(mcDate.SelectionRange.Start.Year, mcDate.SelectionRange.Start.Month, mcDate.SelectionRange.Start.Day, int.Parse(hour), int.Parse(minute), 0);
            blAppointments.AvailableSlots(dtTime, typeOfService,)
        }

        private void chb_Checked(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                typeOfService = rb.Text;
            }
        }

        private void cmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
             o
        }
    }
}


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
    public partial class UC_AppointmentValidation : UserControl
    {

        int startTime, endTime, activeSlots;
        bool satActivated, sunActivated;

        private void cmbStartWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            startTime = int.Parse(GetHour(cmbStartWork.Text));
        }

        private void cmbEndWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            endTime = int.Parse(GetHour(cmbEndWork.Text));
        }

        private void txtSlot_TextChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(txtSlot.Text, out value);
            if (value > 0 && value<=10)
                activeSlots = value;
        }

        private void ckbSaturday_CheckedChanged(object sender, EventArgs e)
        {
                satActivated = ckbSaturday.Checked;
        }

        private void ckbSunday_CheckedChanged(object sender, EventArgs e)
        {
            sunActivated = ckbSunday.Checked;
        }

        public UC_AppointmentValidation()
        {
            InitializeComponent();
        }

        private string GetHour(string hour)
        {
            return hour.Split(':')[0];
        }

        private void UC_AppointmentValidation_Load(object sender, EventArgs e)
        {
            startTime = MainPage.StartTime;
            endTime = MainPage.EndTime;

            activeSlots = MainPage.ActiveSlots;

            satActivated = MainPage.SaturdayActivated;
            sunActivated = MainPage.SundayActivated;

            ckbSunday.Checked = sunActivated;
            ckbSaturday.Checked = satActivated;
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            UpdateAll();
            MessageBox.Show("Updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UC_Dashboard dc = new UC_Dashboard();
            this.Controls.Clear();
            Controls.Add(dc);            
        }

        private void UpdateAll()
        {
            MainPage.SundayActivated = sunActivated;
            MainPage.SaturdayActivated = satActivated;

            MainPage.ActiveSlots = activeSlots;

            MainPage.StartTime = startTime;
            MainPage.EndTime = endTime;
        }

    }
}

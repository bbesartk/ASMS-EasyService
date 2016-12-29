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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UC_RegisterServiceName extraService = new UC_RegisterServiceName();
            this.Controls.Add(extraService);
            
        }

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            //int start = int.Parse(cmbStart.Text.Split(':')[0].ToString());
            //int end = int.Parse(cmbEnd.Text.Split(':')[0].ToString());
            //if (start != 0 && end != 0)
            //{
            //    MainPage.StartTime = start;
            //    MainPage.EndTime = end;

            //    MessageBox.Show("Working hours are successfully updated!");
            //}
            //else MessageBox.Show("Invalid Time!");

            
        }

        private void btnActiveSlots_Click(object sender, EventArgs e)
        {
            int numberOfSlots = 0;

            //int.TryParse(txbSlot.Text, out numberOfSlots);
            //if(numberOfSlots!=0)
            //{
            //    MainPage.ActiveSlots = numberOfSlots;
            //    MessageBox.Show("Active Slots are successfully updated!");
            //}
            //else MessageBox.Show("Invalid Number!");
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text.Length>5 && txbPassword.Text.Length>5)
            {
                string pw = txbPassword.Text.ToString();
                string user = txbUsername.Text.ToString();

                MainPage.Username = user;
                MainPage.Password = pw;

                txbUsername.Clear();
                txbPassword.Clear();
                MessageBox.Show("Credentials hours are successfully updated!");
            }
            else MessageBox.Show("Invalid Credentials!");
        }
    }
}

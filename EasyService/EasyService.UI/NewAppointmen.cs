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
using ES.EntityLayer.General;
using ES.EntityLayer.Appointments;

namespace EasyService.UI
{
    public partial class NewAppointmen : Form
    {
        readonly Vehicle _vehicle;
        static string typeOfService;
        static int slotNumber;
        DateTime date { get; set; }
        private List<Slot> ListOfAllSlots = new List<Slot>();

        public Appointment NewAppointment { get; set; }

        ServiceType serviceType;

        public NewAppointmen(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            for (int i = 0; i < MainPage.ActiveSlots; i++)
            {
                ListOfAllSlots.Add(new Slot(i + 1, "Slot" + (i + 1)));
            }
            cmbSlot.DataSource = ListOfAllSlots;
        }

        private void NewAppointmen_Load(object sender, EventArgs e)
        {
            mcDate.MinDate = DateTime.Now.Date;
            typeOfService = rbSmall.Checked ? rbSmall.Text : rbMajor.Text;

          


            for (int i = MainPage.StartTime; i <= MainPage.EndTime; i++)
            {
                cmbHour.Items.Add(i + ":00");
            }
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

        private void txbSubject_MouseClick(object sender, MouseEventArgs e)
        {
            txbSubject.Text = "";
        }


        private void cmbHour_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSlot.Enabled = true;
            string hour = cmbHour.Text.Split(':')[0];
            string minute = cmbHour.Text.Split(':')[1];
            date = new DateTime(mcDate.SelectionRange.Start.Year, mcDate.SelectionRange.Start.Month, mcDate.SelectionRange.Start.Day, int.Parse(hour), int.Parse(minute), 0, 0, 0);

           
            cmbSlot.DataSource = blAppointments.AvailableSlots(date, typeOfService, slotNumber, 17, ListOfAllSlots);

        }

        private void chb_Checked(object sender, EventArgs e)
        {
            typeOfService = rbSmall.Checked ? rbSmall.Text : rbMajor.Text;
            this.serviceType = rbSmall.Checked ? ServiceType.SmallService : ServiceType.MajorService;
        }

        private void cmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
            slotNumber = dalSlot.GetSlotNumber(ListOfAllSlots, cmbSlot.SelectedItem.ToString());
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (blAppointments.IsValid(date, MainPage.StartTime, MainPage.EndTime))
                {


                    MessageBox.Show("Appointment successfully saved!", "New Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult = DialogResult.OK;
                    NewAppointment = new Appointment(txbSubject.Text, date, slotNumber, serviceType, _vehicle);
                    ListOfAllSlots.Clear();
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error - not valid appointment!");
            }
        }

        private void cmbHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


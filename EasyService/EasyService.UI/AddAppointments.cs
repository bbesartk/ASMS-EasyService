using ES.BusinessLayer;
using ES.DataAccessLayer;
using ES.EntityLayer.Appointments;
using ES.EntityLayer.General;
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

namespace EasyService.UI
{
    public partial class AddAppointments : Form
    {
        public Vehicle _vehicle;
        public string _serviceType;
        public int _slotRowNumber;
        public int _workStartTime = MainPage.StartTime;
        public int _workEndTime = MainPage.EndTime;

        public int _startTime, _endTime;
        public List<Slot> _allSlots = new List<Slot>();
        public List<string> _availableTime = new List<string>();
        public DateTime _date { get; set; }
        public DateTime dt { get; set; }
        public Appointment NewAppointment { get; set; }
        public bool _sunday = MainPage.SundayActivated;
        public bool _saturday = MainPage.SaturdayActivated;

        public AddAppointments()
        {
            InitializeComponent();
            FillControls();
            _vehicle = null;
            rbNewClient.Visible = true;
            rbNewClient.Checked = true;

            rbExistingClient.Checked = false;
            rbExistingClient.Visible = false;
        }

        public AddAppointments(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
            FillControls();
            rbNewClient.Visible = false;
            rbNewClient.Checked = false;

            rbExistingClient.Checked = true;
            rbExistingClient.Visible = true;
        }

        private void txtSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSubject.Text == "  Appointment Subject here...")
                txtSubject.Clear();
        }

        private void AddAppointments_Load(object sender, EventArgs e)
        {
            dtpAppointment.MinDate = DateTime.Now;
            cmbAvailableSlot.Visible = false;
            lblSlot.Visible = false;
            lblKoha.Visible = false;
            cmbKoha.Visible = false;
            btnAddAppointment.Enabled = false;
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serviceType = cmbServiceType.SelectedValue.ToString();

            lblSlot.Visible = true;
            cmbAvailableSlot.Visible = true;
            
        }

        private int GetStartTime(string stringHour)
        {
            string hour = stringHour.Split(':')[0];
            return int.Parse(hour);
        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {
            _date = dtpAppointment.Value;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if(_vehicle == null)
            {
                this.Hide();
                using (NewClient nc = new NewClient())
                {

                    nc.ShowDialog();
                    if (nc.DialogResult==DialogResult.OK)
                    {
                        _vehicle = nc.Vehicle;
                        this.Close();
                    }
                }
                this.Show();
            }
            try
            {
                if (blAppointments.IsValid(dt,_workStartTime,_workEndTime,_saturday,_sunday))
                {
                    bool newClient = rbNewClient.Checked;
                    NewAppointment = new Appointment(txtSubject.Text,dt,_serviceType,_startTime,GetEndTime(_startTime,cmbServiceType.SelectedValue.ToString()),_slotRowNumber,_vehicle,newClient);
                    MessageBox.Show("Appointment successfully saved!", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    DialogResult = DialogResult.OK;
                    _allSlots.Clear();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error - not valid appointment!");
            }
        }

        private void cmbAvailableSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DateTime(_date.Year, _date.Month, _date.Day, _startTime, 0, 0);
            _slotRowNumber = dalSlot.GetSlotNumber(_allSlots, cmbAvailableSlot.SelectedItem.ToString());
            cmbKoha.DataSource = blAppointments.AvailableTime(dt, _serviceType, _slotRowNumber, _workEndTime, _availableTime);
            lblKoha.Visible = true;
            cmbKoha.Visible = true;
        }

        private void cmbKoha_SelectedIndexChanged(object sender, EventArgs e)
        {
            _startTime = GetStartTime(cmbKoha.Text);
            btnAddAppointment.Enabled = true;
        }

        private int GetEndTime(int startTime,string serviceType)
        {
            if (serviceType == "Small Service")
                _endTime = startTime + 1;
            else if (serviceType == "Major Service")
                _endTime = startTime + 3;

            return _endTime;
        }

        private void FillControls()
        {
            for (int i = 0; i < MainPage.ActiveSlots; i++)
            {
                _allSlots.Add(new Slot(i + 1, "Slot" + (i + 1)));
            }

            for (int i = MainPage.StartTime; i < MainPage.EndTime; i++)
            {
                _availableTime.Add(i + ":00");
            }

            string[] serviceType = { "Small Service", "Major Service" };

            cmbAvailableSlot.DataSource = _allSlots;

            cmbKoha.DataSource = _availableTime;
            _startTime = int.Parse(_availableTime[0].Split(':')[0]);
            _slotRowNumber = dalSlot.GetSlotNumber(_allSlots, _allSlots[0].Description);
            cmbServiceType.DataSource = serviceType;
            _serviceType = serviceType[0];
            _date = DateTime.Now.Date;
        }
    }
}

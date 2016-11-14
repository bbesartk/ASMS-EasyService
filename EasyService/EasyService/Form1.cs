using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Employee;
using EasyService.Appointments;
using EasyService.Autos;
using System.Windows.Forms;
using EasyService.DataAccess;

namespace EasyService
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContactInfo ci = new ContactInfo(GeneralUse.FormatNames("pRisHtInA"), "sadasd", "+12345678901", "dsadb@msn.com");

            //string i = ci.City;
            
            //Employee.Employee emp = new Employee.Employee("dsad", "dsadas", true, ci, "password", "admin");
            ////Appointment app = new Appointment();
            ////app.IsPending = true;

            //Vehicle vh = new Vehicle();
            //app.Vehicle = (Vehicle)vh;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = new Vehicle();
            int ora;
            int.TryParse(textBox1.Text, out ora);
            DateTime dateOfMeeting = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, ora, 0, 0);

           
                daAppointments.ListAppointments.Add(new Appointment(dateOfMeeting, selectedVehicle));
            
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}

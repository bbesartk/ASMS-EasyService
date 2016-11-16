using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASMS_EasyService.Vehicles;
using ASMS_EasyService.Employees;
using ASMS_EasyService.Properties;
using ASMS_EasyService.General;
using ASMS_EasyService.Clients;

namespace ASMS_EasyService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContactInfo cc = new ContactInfo("dsad", "sada", "dsadas", "sadasd");
            Client c1 = new Client("fsdf", "sadsad", cc);
            Vehicle v1 = new Vehicle("dsadsa", 2011, "dsadsa", "sadsa", 24234, c1);
            Employee e1 = new Employee("dsadas", "sadasd", true, cc, "sada", "admin");
            List<Inspection> l1 = new List<Inspection>();
            Service s1 = new Service(DateTime.Now, 24235, 24, l1, e1);
            
        }
    }
}

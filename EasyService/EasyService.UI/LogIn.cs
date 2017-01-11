using ES.EntityLayer.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.BusinessLayer;
using ES.EntityLayer.Employees;

namespace EasyService.UI
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();

            DataTest.Insert();
            DataTest.InitialiseEmployee();
            Boss b = new Boss("admin", "password");
            b.Id = "111A";
            blEmployees.InsertEmployees(b);
            blStock.AllItemsInserted();
            
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text=="admin" && txbPw.Text=="admin")
            {
                using (MainPage mp = new MainPage())
                {
                    mp.ShowDialog();
                }
            }

            foreach (Employee emp in blEmployees.GetAllEmployees())
            {
                if (emp.Username == txbUsername.Text && emp.Password == txbPw.Text)
                {
                    string logintype = emp.Id.Substring(emp.Id.Length - 1);
                    GrantAccess(logintype, emp.Id);
                    using (MainPage mp = new MainPage())
                    {
                        
                        mp.ShowDialog();

                    }
                }
            }

           
        }

        private void GrantAccess(string loginType,string id)
        {
            switch(loginType)
            {
                case "A":
                    MainPage.Access = blEmployees.GetAdmin(id).Access;
                    break;
                case "M":
                    MainPage.Access = blEmployees.GetMechanic(id).Access;
                    break;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}

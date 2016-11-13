using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService;
using System.Windows.Forms;

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

            string i = ci.City;
        }
        

        

    }
}

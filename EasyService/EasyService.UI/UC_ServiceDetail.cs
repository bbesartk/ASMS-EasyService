using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Appointments;
using ES.EntityLayer.Services;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class UC_ServiceDetail : UserControl
    {
        List<ServiceName> lista = new List<ServiceName>();
        public UC_ServiceDetail()
        {
            InitializeComponent();

            

            lista.Add(new ServiceName("Fuel", true, true, true, 1));
            foreach (var item in lista)
            {
                listBoxServices.Items.Add(item);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox chb = (CheckedListBox)sender;

            MessageBox.Show(chb.SelectedItem.ToString());
        }

        private void UC_ServiceDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void rbMajorService_CheckedChanged(object sender, EventArgs e)
        {
           
            if(rbMajorService.Checked)
            {
                listBoxServices.Items.Clear();
                foreach (var item in lista)
                {
                    listBoxServices.Items.Add(item);
                    
                }
            }
            else
            {
                listBoxServices.Items.Clear();
            }
        }
    }
}

using ES.BusinessLayer;
using ES.EntityLayer.Services;
using ES.EntityLayer.Stock;
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
    public partial class InspectionDetail : Form
    {
        private readonly ServiceName _serviceName;
        public InspectionDetail(ServiceName serviceName)
        {
            InitializeComponent();
            _serviceName = serviceName;
        }

        private void InspectionDetail_Load(object sender, EventArgs e)
        {
            try
            {
                lblServiceName.Text = _serviceName.Description;
                List<Item> itemsByCategory = blStock.GetAllByCategory(_serviceName.ItemCategory);

                cmbItemsByCategory.DataSource = itemsByCategory;
            }
            catch (Exception)
            {

                MessageBox.Show("This Service isnt well validated!");
            }
           

        }

        private void cmbItemsByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbPrice.Text = cmbItemsByCategory.SelectedItem.ToString();
        }
    }
}

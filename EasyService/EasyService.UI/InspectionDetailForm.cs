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
    public partial class InspectionDetailForm : Form
    {
        public InspectionDetail InspectionDetail { get; set; } = new InspectionDetail(new Item("dsadasd","dsadas",4,2,Category.CoolAndHeat),4);
        public readonly ServiceName _serviceName;

        public InspectionDetailForm(ServiceName serviceName)
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

            Item item2 = blStock.GetAllByCategory(_serviceName.ItemCategory)[cmbItemsByCategory.SelectedIndex];
            
            InspectionDetail.Item = item2;
            txbPrice.Text = item2.Price.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int quantity;

            int.TryParse(txbQuantity.Text, out quantity);
            
            InspectionDetail.Quantity = quantity;

            DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}

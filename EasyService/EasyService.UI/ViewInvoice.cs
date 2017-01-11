using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Finance;
using ES.EntityLayer.Services;
using ES.BusinessLayer;


namespace EasyService.UI
{
    public partial class ViewInvoice : Form
    {
        public List<DisplayItem> all = new List<DisplayItem>();
        public Invoice _invoice;
        public ViewInvoice(Invoice invoice)
        {
            InitializeComponent();
            _invoice = invoice;
            foreach (var item in _invoice.Service.ListInspection)
            {
                if(item.InspectionDetail!=null)
                all.Add(new DisplayItem(item.ToString(),item.InspectionDetail.Item.ItemNumber,item.InspectionDetail.Item.Name,item.InspectionDetail.Quantity.ToString(),item.InspectionDetail.Item.Price.ToString()));
                else if(item.InspectionDetail==null)
                {
                    all.Add(new DisplayItem(item.ToString()));
                }
                
            }
            dataGridView1.DataSource = all;
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBillAndSave_Click(object sender, EventArgs e)
        {
            _invoice.ServicedVehicle.ServiceList.Add(_invoice.Service);
            blInvoice.InsertInvoice(_invoice);

        }
    }
}

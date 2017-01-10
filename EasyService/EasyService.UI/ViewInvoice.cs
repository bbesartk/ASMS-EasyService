using ES.BusinessLayer;
using ES.EntityLayer.Finance;
using ES.EntityLayer.Services;
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
    public partial class ViewInvoice : Form
    {
        private readonly Invoice _invoice;
        public ViewInvoice(Invoice invoice)
        {
            InitializeComponent();
            _invoice = invoice;
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            List<InspectionDetail> all = new List<InspectionDetail>();
            foreach (var item in _invoice.Service.ListInspection)
            {
                all.Add(item.InspectionDetail);
            }

            dgItems.DataSource = all;

        }

        private void btnBillAndSave_Click(object sender, EventArgs e)
        {
            _invoice.ServicedVehicle.ServiceList.Add(_invoice.Service);
            blInvoice.InsertInvoice(_invoice);
            this.Close();
        }
    }
}

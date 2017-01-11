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
        public bool _read;
        public ViewInvoice(Invoice invoice,bool read)
        {
            InitializeComponent();
            _invoice = invoice;
            _read = read;
            if(_read==true)
            {
                btnBillAndSave.Text = "CLOSE INFO!";
            }
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
            if(_invoice.Client==null)
            {
                lblClientAddress.Text = _invoice.Company.ContactInfo.Address;
                lblClientCity.Text = _invoice.Company.ContactInfo.City;
                lblClientName.Text = _invoice.Company.CompanyName;
                lblClientPhoneNumber.Text = _invoice.Company.ContactInfo.PhoneNumber;
                lblEmail.Text = _invoice.Company.ContactInfo.Email;
            }
            else if(_invoice.Company==null)
            {
                lblClientAddress.Text = _invoice.Client.ContactInfo.Address;
                lblClientCity.Text = _invoice.Client.ContactInfo.City;
                lblClientName.Text = _invoice.Client.Name + "  " + _invoice.Client.Lastname;
                lblClientPhoneNumber.Text = _invoice.Client.ContactInfo.PhoneNumber;
                lblEmail.Text = _invoice.Client.ContactInfo.Email;
            }

            lblFinalTotal.Text += _invoice.FinalTotal.ToString();
            lblVAT.Text += _invoice.Vat.ToString();
            lblTotal.Text += _invoice.Total.ToString();
            lblInvoiceDate.Text = _invoice.DateOfBill.ToShortDateString();
            invoiceNr.Text += _invoice.Id.ToString("000");
            lblVehicle.Text = _invoice.ServicedVehicle.Type + " - " + _invoice.ServicedVehicle.Model;
            lblVehiclePlate.Text = _invoice.ServicedVehicle.LicensePlate.ToString();
            lblServicedBy.Text ="Serviced by: "+ _invoice.ServicedBy.Name + " " + _invoice.ServicedBy.Lastname;
            lblKm.Text = _invoice.Service.ServicedKm.ToString() + "/ km";
            

        }

        private string getTotal()
        {
            double x = _invoice.Total - (_invoice.Vat/100 *_invoice.Total);
            return x.ToString();
        }

        private void btnBillAndSave_Click(object sender, EventArgs e)
        {
            if (_read == true)
            {
                this.Close();
            }
            else if(_read==false)
            {
                DialogResult = DialogResult.Yes;
                _invoice.ServicedVehicle.ServiceList.Add(_invoice.Service);
                blInvoice.InsertInvoice(_invoice);
                this.Close();
            }

        }
    }
}

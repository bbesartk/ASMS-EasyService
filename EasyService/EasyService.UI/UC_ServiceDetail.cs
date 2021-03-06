﻿using System;
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
using ES.DataAccessLayer;
using ES.EntityLayer.Stock;
using ES.EntityLayer.Finance;
using ES.EntityLayer.Vehicle;
using ES.EntityLayer.Employees;
using ES.EntityLayer.Clients;

namespace EasyService.UI
{
    public partial class UC_ServiceDetail : UserControl
    {
        List<ServiceName> lista = dalServiceName.GetAll();

        List<Inspection> allInspections = new List<Inspection>();
        Mechanic servicedBy { get; set; }
        double WorkPay { get; set; } = 20;
        double VAT { get; set; } = 15;
        double CurrentKm { get; set; }
        double LastTotal { get; set; }

        private readonly Vehicle _vehicle;
        private readonly Client _client;
        private readonly Company _company;



        public UC_ServiceDetail(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            if (_vehicle.Client != null)
            {
                _client = _vehicle.Client;
            }
            else if (_vehicle.Company != null)
            {
                _company = _vehicle.Company;
            }

            txbVAT.Text = VAT.ToString();
            txbWork.Text = WorkPay.ToString();

            foreach (var item in lista)
            {
                listBoxServices.Items.Add(item);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox chb = (CheckedListBox)sender;
            //merr servisin e klikuar
            var serviceType = dalServiceName.GetServiceName(chb.SelectedItem.ToString());
            //nese servisi nuk eshte null dhe lloji i servisit kerkon qe te behet riparim replacement/ndrrim hapet forma

            if (serviceType != null && serviceType.NeedsReplacement == true)
            {
                //using na mundeson qe ta hapim formen dhe permes dialog reusltit ta marrim te dhenen qe e kemi ruaj aty
                using (InspectionDetailForm ins = new InspectionDetailForm(serviceType))
                {
                    //nese ka nevoj per ndrrim hapet forma i mbushim te dhanat edhe i ruajm ne listen siper 
                    ins.ShowDialog();
                    if (ins.DialogResult == DialogResult.OK)
                    {
                        allInspections.Add(new Inspection(serviceType.Description, new InspectionDetail(ins.InspectionDetail.Item, ins.InspectionDetail.Quantity)));
                    }
                }

            }
            //nese jo atehere ruhet vetem emri i inspektimit dhe jo edhe ndrrimi (se nuk ka pas nderrim dmth)
            else if (serviceType != null && serviceType.NeedsReplacement == false)
            {
                allInspections.Add(new Inspection(serviceType.Description));
            }
            //nese ka diqka gabim qet njoftim
            else MessageBox.Show("This item is not well validated!");

            UpdateTotal();

        }

        private void UC_ServiceDetail_Load(object sender, EventArgs e)
        {
            lblDateOfService.Text += DateTime.Now.Date.ToShortDateString();
            cmbEmployee.DataSource = dalEmployees.GetAll();
            lblTotalPrice.Text = LastTotal.ToString();
        }

        private void rbMajorService_CheckedChanged(object sender, EventArgs e)
        {

            if (rbMajorService.Checked)
            {
                listBoxServices.Items.Clear();
                foreach (var item in lista)
                {
                    if (item.IsInMajorService)
                        listBoxServices.Items.Add(item);

                }
            }
            else if (rbSmallService.Checked)
            {
                listBoxServices.Items.Clear();
                foreach (var item in lista)
                {
                    if (item.IsInMinorService)
                        listBoxServices.Items.Add(item);
                }
            }

        }

        private double CalculateTotal()
        {
            //kjo na ben update totalin vazhdimisht
            double total = 0;

            foreach (var typeOfInspection in allInspections)
            {
                if (typeOfInspection.InspectionDetail != null)
                {
                    total += (typeOfInspection.InspectionDetail.Quantity * typeOfInspection.InspectionDetail.Item.Price);
                }
            }
            return total;
        }

        private void txbCurrentKm_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbCurrentKm.Text == "write...")
            {
                txbCurrentKm.Clear();
                txbCurrentKm.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btnBillAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidKM(CurrentKm) && WorkPay > 0)
                {
                    Service sv = new Service(DateTime.Now, CurrentKm, WorkPay, allInspections, servicedBy,LastTotal);
                    if (_client != null)
                    {
                        using (ViewInvoice vI = new ViewInvoice(new Invoice(sv.ServiceId,_vehicle, sv, _client, servicedBy, VAT,(CalculateTotal()+WorkPay),LastTotal),false))
                        {
                            vI.ShowDialog();
                            if (vI.DialogResult == DialogResult.OK)
                            {
                                UpdateStock();
                                _vehicle.ServiceList.Add(sv);
                            }
                        }
                    }
                    else if (_company != null)
                    {
                        using (ViewInvoice vI = new ViewInvoice(new Invoice(sv.ServiceId,_vehicle, sv, _company, servicedBy, VAT, (CalculateTotal() + WorkPay), LastTotal),false))
                        {
                            vI.ShowDialog();
                            if (vI.DialogResult == DialogResult.Yes)
                            {
                                UpdateStock();
                                _vehicle.ServiceList.Add(sv);                                
                            }
                            else
                            {
                                MessageBox.Show("Service Aborted!", "New service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    DialogResult dg = MessageBox.Show("New service added successfully!", "New service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dg == DialogResult.OK)
                    {
                        UC_ViewServices services = new UC_ViewServices(_vehicle);
                        this.Controls.Clear();
                        this.Controls.Add(services);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Your current kilometres are invalid!");
            }


        }

        private double FinalTotal(double total, double workpay, double vat)
        {
            double totalWork = total + workpay;
            return totalWork+(totalWork*(vat/100));
        }

        private double TotalPaTvsh(double total,double workpay)
        {
            return total + workpay;
        }

        private bool IsValidKM(double km)
        {
            int numberOfServices = _vehicle.ServiceList.Count;
            if (numberOfServices >= 1)
            {
                if (_vehicle.ServiceList[numberOfServices - 1].ServicedKm > km)
                    return false;
                else return true;
            }
            return true; ;
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mechanic = blEmployees.GetAllMechanics()[cmbEmployee.SelectedIndex];
            servicedBy = mechanic;

        }

        private void txbWork_TextChanged(object sender, EventArgs e)
        {
            double workpay = 0;
            double.TryParse(txbWork.Text, out workpay);
            if (workpay > 0)
            {
                WorkPay = workpay;
            }
            UpdateTotal();
        }

        private void txbVAT_TextChanged(object sender, EventArgs e)
        {
            double vat = 0;
            double.TryParse(txbVAT.Text, out vat);
            if (vat > 0)
            {
                VAT = vat;
            }
            UpdateTotal();
        }

        private void txbCurrentKm_TextChanged(object sender, EventArgs e)
        {

            double currentKm = 0;

            double.TryParse(txbCurrentKm.Text, out currentKm);
            if (currentKm > 0)
            {
                CurrentKm = currentKm;
            }


        }

        private void UpdateStock()
        {
            foreach (var item in allInspections)
            {
                var item2 = new Item();
                item2 = blStock.GetItem(item.InspectionDetail.Item.ItemNumber);

                if (item2 != null)
                {
                    item2.Quantiy = item2.Quantiy - item.InspectionDetail.Quantity;
                    blStock.UpdateItem(item2);
                }

            }
        }

        private void UpdateTotal()
        {
            LastTotal = FinalTotal(CalculateTotal(), WorkPay, VAT);
            lblTotalPrice.Text = " " + LastTotal + " €";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.BusinessLayer;
using ES.EntityLayer.Stock;

namespace EasyService.UI
{
    public partial class UC_AddNewItem : UserControl
    {
        Category _category;
        bool _isInStock;
        public UC_AddNewItem()
        {
            InitializeComponent();
        }

        public UC_AddNewItem(Item item)
        {
            InitializeComponent();

            txbId.Text = item.ItemNumber;
            txbId.ReadOnly = true;
            txbName.Text = item.Name;
            txbName.ReadOnly = false;
            txbP.Text = item.Price.ToString();
            txbP.ReadOnly = false;
            txbQuantity.Text = item.Quantiy.ToString();
            txbQuantity.ReadOnly = false;
            comboBox1.SelectedItem = item.Category;
            comboBox1.Enabled = true;
            btnAdd.Text = "UPDATE THIS ITEM";


        }

        private void UC_AddNewItem_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = blStock.GetItemCategories();
        }

        private void txb_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (txb.Text == "write...")
            {
                txb.Clear();
                txb.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD THIS ITEM")
            {
                double price = 0;
                int quantity = 0;

                double.TryParse(txbP.Text, out price);
                int.TryParse(txbQuantity.Text, out quantity);

                try
                {
                    if (_isInStock)
                        blStock.GetItem(txbId.Text).Quantiy += quantity;
                    else
                        blStock.AddItems(new Item(txbId.Text, txbName.Text, price, quantity, _category));
                    CallStock();
                }
                catch
                {
                    MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnAdd.Text == "UPDATE THIS ITEM")
            {
                double price = 0;
                int quantity = 0;

                double.TryParse(txbP.Text, out price);
                int.TryParse(txbQuantity.Text, out quantity);
                try
                {
                    blStock.UpdateItem(txbId.Text, txbName.Text, price, quantity, (Category)comboBox1.SelectedItem);
                    CallStock();
                }
                catch
                {
                    MessageBox.Show("Please fill the fields correctly!", "Invalid atempt input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _isInStock = false;
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            _category = (Category)comboBox1.SelectedItem;
        }


        private void txbId_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Length == 10)
            {
                if (blStock.IsInStock(txt.Text))
                {
                    blStock.MakeReadOnly(txt, txbName, txbP, (ComboBox)comboBox1);
                    _isInStock = true;
                }
            }
        }

        private void CallStock()
        {
            UC_Stock stock = new UC_Stock();
            this.Controls.Clear();
            this.Controls.Add(stock);
        }
    }
}

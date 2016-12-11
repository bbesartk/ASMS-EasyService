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
        private readonly Item _item;
        public UC_AddNewItem()
        {
            InitializeComponent();
        }

        public UC_AddNewItem(Item item)
        {
            InitializeComponent();
            _item = item;
            ReadItem(_item, false);
            // Prepare this Item for being updated

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
                    CallPanel(1);
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
                    blStock.UpdateItem(ChangeItemDetails(_item));
                    CallPanel(2);
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
            _category = (Category)comboBox1.SelectedValue;
        }


        private void txbId_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Length == 10)
            {
                if (blStock.IsInStock(txt.Text))
                {
                    blStock.FillText(txt, txbName, txbP, (ComboBox)comboBox1);
                    blStock.MakeReadOnly(txbName, txbP, (ComboBox)comboBox1, true);
                    _isInStock = true;
                }
            }
            else if (txt.Text.Length > 0)
            {
                blStock.MakeReadOnly(txbName, txbP, (ComboBox)comboBox1, false);
                _isInStock = false;
            }
        }

        private void CallPanel(int number)
        {
            switch (number)
            {
                case 1:
                    UC_Stock stock = new UC_Stock();
                    this.Controls.Clear();
                    this.Controls.Add(stock);
                    break;
                case 2:
                    UC_Item item = new UC_Item(blStock.GetAllByCategory(_category));
                    this.Controls.Clear();
                    this.Controls.Add(item);
                    break;
            }
        }

        private void ReadItem(Item item, bool readOnly)
        {
            comboBox1.Enabled = readOnly;
            comboBox1.SelectedValue = item.Category;


            txbId.Text = item.ItemNumber;
            txbId.ReadOnly = true;

            txbName.Text = item.Name;
            txbName.ReadOnly = readOnly;

            txbP.Text = item.Price.ToString();
            txbP.ReadOnly = readOnly;

            txbQuantity.Text = item.Quantiy.ToString();
            txbQuantity.ReadOnly = readOnly;

            btnAdd.Text = "UPDATE THIS ITEM";
        }

        private Item ChangeItemDetails(Item item)
        {
            item.Name = txbName.Text;
            item.Price = double.Parse(txbP.Text);
            item.Category = _category;
            item.Quantiy = int.Parse(txbQuantity.Text);
            return item;
        }
    }
}

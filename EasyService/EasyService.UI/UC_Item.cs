using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Stock;
using ES.BusinessLayer;

namespace EasyService.UI
{
    public partial class UC_Item : UserControl
    {
        private List<Item> _listOfItems;
        public UC_Item(List<Item> listOfItems)
        {
           
            InitializeComponent();
            _listOfItems = listOfItems;

        }

        private void txbKerko_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbKerko.Text == "search for an item...")
            {
                txbKerko.Clear();
                txbKerko.ForeColor = Color.FromArgb(44, 55, 59);
            }
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {
            dgItems.DataSource = _listOfItems;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Stock stock = new UC_Stock();
            this.Controls.Clear();
            this.Controls.Add(stock);
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Item item = (Item)dgItems.Rows[e.RowIndex].DataBoundItem;
            EditItem(item);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            var item = blStock.GetItemByList(txbKerko.Text,_listOfItems);
            if(item != null)
            {
                EditItem(item);
            }
        }

        private void EditItem(Item itemi)
        {
            UC_AddNewItem editItem = new UC_AddNewItem(itemi);
            this.Controls.Clear();
            this.Controls.Add(editItem);
        }
    }
}

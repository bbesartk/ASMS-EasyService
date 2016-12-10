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

namespace EasyService.UI
{
    public partial class UC_Item : UserControl
    {
        private readonly List<Item> _listOfItems;
        public UC_Item(List<Item> listOfItems)
        {
            _listOfItems = listOfItems;
            InitializeComponent();
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

        }
    }
}

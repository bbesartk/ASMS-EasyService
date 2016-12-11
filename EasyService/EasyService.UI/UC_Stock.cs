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
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void btnServiceParts_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.ServiceParts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.Brakes);
        }

        private void SeeAlByCategory(Category category)
        {
            List<Item> listofItems = blStock.GetAllByCategory(category);
            itemPanel.Visible = true;
            UC_Item item = new UC_Item(listofItems);
            itemPanel.Controls.Clear();
            itemPanel.Controls.Add(item);
        }

        private void btnEngines_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.EngineParts);
        }

        private void btnTransmission_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.Transmission);
        }

        private void btnCoolHeat_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.CoolAndHeat);
        }

        private void btnLubrificants_Click(object sender, EventArgs e)
        {
            SeeAlByCategory(Category.Lubrificants);
        }

        private void UC_Stock_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //paraqitja e pamjes per futjen e nje artikulli te ri ne stock

            UC_AddNewItem newItem = new UC_AddNewItem();
            this.Controls.Clear();
            this.Controls.Add(newItem);
        }
    }
}

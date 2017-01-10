using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.Services
{
    public class DisplayItem
    {

        public string ItemNumber { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public DisplayItem(string itemNumber, string itemName, int quantity, double price)
        {
            ItemName = itemName;
            ItemNumber = itemNumber;
            Quantity = quantity;
            Price = price;
        }

    }
}

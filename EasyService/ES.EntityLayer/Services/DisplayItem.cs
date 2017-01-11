using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.Services
{
    public class DisplayItem
    {
        public string InspectionName { get; set; }

        public string ItemNumber { get; set; }

        public string ItemName { get; set; }

        public string Quantity { get; set; }

        public string Price { get; set; }

        public string Total { get
            {
                double p;
                int q;
                double.TryParse(Price, out p);
                int.TryParse(Quantity, out q);
                return (p * q).ToString();
            }
        }

        public DisplayItem(string inspectionName,string itemNumber, string itemName, string quantity,string price)
        {
            InspectionName = inspectionName;
            ItemName = itemName;
            ItemNumber = itemNumber;
            Quantity = quantity;
            Price = price;
        }
        public DisplayItem(string inspectionName)
        {
            InspectionName = inspectionName;
            ItemNumber = " / ";
            ItemName = " / ";
            Quantity = " / ";
            Price = " / ";
        }

    }
}

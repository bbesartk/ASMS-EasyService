using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.Stock
{
    public enum Category
    {
        ServicePart,
        Brakes,
        EngineParts,
        TRANSMISSION,
        COOLandHeat,
        Lubrificants
    }
    public class Item
    {
        //emri nrPersonal qmimi sasiaStok

        #region Private Members
        private string _itemNumber;
        private string _name;
        private double _price = 0;
        private int _quantity = 0;

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be empty!");
                }
                else _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price must be positive number!");
                }
                else _price = value;
            }
        }
        public int Quantiy
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Quantity must be positive");
                }
                else _quantity = value;
            }
        }

        public string ItemNumber
        {
            get
            {
                return _itemNumber;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a real item number!");
                else _itemNumber = value;
            }
        }

        public Category Category { get; set; }


        public Item(string itemNumber, string itemName, double price, int quantity, Category category)
        {
            Name = itemName;
            ItemNumber = itemNumber;
            Price = price;
            Quantiy = quantity;
            Category = category;
        }
        #endregion
    }
}

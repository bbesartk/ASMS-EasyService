using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.Finance
{
    public class ServicedInspection
    {
        #region PrivateMembers
        private string _description;
        private int _quantity;
        private double _price;

        #endregion

        #region Properties
        public string Description
        {
            get { return _description; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a description!");
                else
                    _description = value;
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 1)
                    throw new Exception("Quantity must be positive!");
                else _quantity = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Price can not be negative!");
                else _price = value;
            }
        }
        public decimal Total
        {
            get
            {
                return (decimal)(Quantity * Price);
            }
        }

        public string ImagePath { get; set; }
        #endregion

        #region Constructors
        public ServicedInspection(string description, int quantity, double price, string imgPath)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
            ImagePath = imgPath;
            
        }
        #endregion
    }
}

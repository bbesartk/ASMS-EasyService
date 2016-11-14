using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Autos
{
    public class InspectionServiced
    {
        #region PrivateMembers
        private int _quantity;
        private double _price;
        #endregion

        #region Properties
        public string Description { get; set; }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Sasia duhet pozitive");
                }
                else _quantity = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Cmimi nuk guxon te jete negativ");
                }
                else _price = value;
            }
        }
        public double Total
        {
            get
            {
                return Quantity * Price;
            }
        }
        #endregion

        #region Constuctors
        public InspectionServiced(string description, int quantity, double price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Autos
{
    public class ServiceDetail
    {
        #region Properties
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total
        {
            get
            {
                return Quantity * Price;
            }
        }
        #endregion

        #region Constuctors
        public ServiceDetail()
        {

        }
        public ServiceDetail(string description,int quantity,double price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
        #endregion
    }
}

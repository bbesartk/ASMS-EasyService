using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Autos
{
    public class ServiceDetail
    {
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
    }
}

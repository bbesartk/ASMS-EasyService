using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Stock;

namespace ES.EntityLayer.Services
{
    public class InspectionDetail
    {
        #region PrivateMembers


        #endregion

        #region Properties
        public Item Item { get; set; }

        public int Quantity { get; set; }
        #endregion

        #region Constructors
        public InspectionDetail(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
        #endregion
    }
}

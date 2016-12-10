using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Stock;

namespace ES.BusinessLayer
{
    class blStock
    {
        private static List<Item> _listOfItems = new List<Item>();

        public List<Item> GetAllByCategory(Category category)
        {
            List<Item> listItems = new List<Item>();
            foreach (var item in _listOfItems)
            {
                if (item.Category == category )
                {
                    listItems.Add(item);
                }
            }
            return listItems;
        }
    }
}

using ES.EntityLayer.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DataAccessLayer
{
    public class dalStock
    {
        private static List<Item> _listOfItems = new List<Item>();

        public static void Insert(Item item)
        {
            _listOfItems.Add(item);
        }

        public static Item GetSingleItem(string id)
        {
            foreach (var item in _listOfItems)
            {
                if(item.ItemNumber==id)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<Item> GetAll()
        {
            return _listOfItems;
        }

        public static void Remove(string id)
        {
            var item = GetSingleItem(id);
            _listOfItems.Remove(item);
        }

        public static void Update(Item item)
        {
            foreach (var itemOnDb in _listOfItems)
            {
                if(itemOnDb.ItemNumber == item.ItemNumber)
                {
                    itemOnDb.Name = item.Name;
                    itemOnDb.Price = item.Price;
                    itemOnDb.Category = item.Category;
                    itemOnDb.Quantiy = item.Quantiy;
                }
            }
            

        }

        

    }
}

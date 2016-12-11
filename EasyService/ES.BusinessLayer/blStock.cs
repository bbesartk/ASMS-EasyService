using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Stock;
using System.Windows.Forms;
using ES.DataAccessLayer;


namespace ES.BusinessLayer
{
    public class blStock
    {
        private static List<Item> _listOfItems = dalStock.GetAll();

        #region CRUD

        public static void AddItems(Item itm)
        {
            if (AreValid(itm.ItemNumber, itm.Name, itm.Price, itm.Quantiy))
            {
                dalStock.Insert(itm);
            }
            else throw new Exception("Invalid insert attepmt!");
        }
        
        public static void UpdateItem(string id, string name, double price, int quantity, Category cat)
        {
            if (AreValid(id, name, price, quantity))
                dalStock.Update(id, name, price, quantity, cat);
            else throw new Exception("Invalid update attempt!");
        }

        public static List<Item> GetAllItems()
        {
            return _listOfItems;
        }

        public static void DeleteItem(string id)
        {
            dalStock.Remove(id);
        }
        public static List<Category> GetItemCategories()
        {
             List<Category> list = new List<Category>() { Category.EngineParts, Category.Lubrificants, Category.CoolAndHeat, Category.ServiceParts, Category.Transmission };

            return list;
        }

        #endregion

        #region Queries

        public static bool IsInStock(string id)
        {
            foreach (var item in _listOfItems)
            {
                if (item.ItemNumber == id)
                    return true;
            }
            return false;
        }

        public static Item GetItem(string id)
        {
            foreach (var item in _listOfItems)
            {
                if (item.ItemNumber == id)
                    return item;
            }
            return null;
        }

        public static Category GetCategory(string id)
        {
            var item = GetItem(id);

            return item.Category;
        }


        public static List<Item> GetAllByCategory(Category category)
        {
            List<Item> listItems = new List<Item>();
            foreach (var item in _listOfItems)
            {
                if (item.Category == category)
                {
                    listItems.Add(item);
                }
            }
            return listItems;
        }

        public static void MakeReadOnly(TextBox txbId, TextBox itemName, TextBox itemPrice, ComboBox c1)
        {
            txbId.ReadOnly = true;
            itemName.Text = GetItem(txbId.Text).Name;
            itemName.ReadOnly = true;
            itemPrice.Text = GetItem(txbId.Text).Price.ToString();
            itemPrice.ReadOnly = true;
            c1.SelectedItem = GetItem(txbId.Text).Category;
            c1.Enabled = false;
        }

        private static bool AreValid(string id, string name, double price, int quantity)
        {
            if (id != "write..." && !String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(name) && name != "write..." && price > 0 && quantity > 0)
                return true;
            else return false;
        }
    }
    #endregion
}

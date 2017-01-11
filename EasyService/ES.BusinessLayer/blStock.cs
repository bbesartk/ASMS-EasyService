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

        #region CRUD

        public static void AddItems(Item itm)
        {
            if (AreValid(itm.ItemNumber, itm.Name, itm.Price, itm.Quantiy))
            {
                dalStock.Insert(itm);
            }
            else throw new Exception("Invalid insert attepmt!");
        }
        
        public static void UpdateItem(Item item)
        {
            if(item !=null)
            {
                dalStock.Update(item);
            }
            else throw new Exception("Invalid update attempt!");
        }

        public static List<Item> GetAllItems()
        {
            return dalStock.GetAll();
        }

        public static void DeleteItem(string id)
        {
            dalStock.Remove(id);
        }
        public static List<Category> GetItemCategories()
        {
             List<Category> list = new List<Category>() { Category.EngineParts, Category.Lubrificants, Category.CoolAndHeat, Category.ServiceParts, Category.Transmission, Category.Brakes };
            return list;
        }

        #endregion

        #region Queries

        public static bool IsInStock(string id)
        {
            foreach (var item in dalStock.GetAll())
            {
                if (item.ItemNumber == id)
                    return true;
            }
            return false;
        }

        public static Item GetItem(string id)
        {
            foreach (var item in dalStock.GetAll())
            {
                if (item.ItemNumber == id)
                    return item;
            }
            return null;
        }

        public static Item GetItemByList(string id,List<Item> list)
        {
            foreach (var item in list)
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
            foreach (var item in dalStock.GetAll())
            {
                if (item.Category == category)
                {
                    listItems.Add(item);
                }
            }
            return listItems;
        }

        public static void FillText(TextBox txbId, TextBox itemName, TextBox itemPrice, ComboBox c1)
        {
            itemName.Text = GetItem(txbId.Text).Name;
            
            itemPrice.Text = GetItem(txbId.Text).Price.ToString();
            
            c1.SelectedItem = GetItem(txbId.Text).Category;
            
        }
        public static void MakeReadOnly( TextBox itemName, TextBox itemPrice, ComboBox c1, bool value)
        {
            itemName.ReadOnly = value;
            itemPrice.ReadOnly = value;
            c1.Enabled = !value;
        }

        private static bool AreValid(string id, string name, double price, int quantity)
        {
            if (id != "write..." && !String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(name) && name != "write..." && price > 0 && quantity > 0)
                return true;
            else return false;
        }


        public static int CountAllItems()
        {
            int total = 0;
            foreach (var item in GetAllItems())
            {
                total += item.Quantiy;
            }
            return total;
        }


        public static void AllItemsInserted()
        {
            ///*/http://www.eurocarparts.com/car-parts*/   qitu i merr listen e Itemav- shti sa tmujsh
            //

            dalStock.Insert(new Item("123456789", "Instruments/warning lamps", 2.1, 12, Category.ServiceParts));
            dalStock.Insert(new Item("124578962", "Switches/controls", 1.5, 5, Category.ServiceParts));
            dalStock.Insert(new Item("123612345", "Engine oil leaks", 8, 21, Category.EngineParts));
            dalStock.Insert(new Item("123745854", "Engine oil", 12, 45, Category.EngineParts));
            dalStock.Insert(new Item("123678478", "Engine oil filter", 1.8, 7, Category.EngineParts));
            dalStock.Insert(new Item("145678455", "Manual transminsson oil leaks", 4.5, 8, Category.Transmission));
            dalStock.Insert(new Item("124897678", "Manual transmission oil", 9.4, 26, Category.Transmission));
            dalStock.Insert(new Item("123479655", "Fuel tank leakage", 24, 12, Category.Lubrificants));
            dalStock.Insert(new Item("123987546", "Fuel system leakage", 20.4, 12, Category.Lubrificants));
            dalStock.Insert(new Item("321456712", "Air Filte", 2.5, 36, Category.CoolAndHeat));
            dalStock.Insert(new Item("456114311", "Air conditioning", 7, 16, Category.CoolAndHeat));
            dalStock.Insert(new Item("231444567", "Brakes", 15, 31, Category.Brakes));
            dalStock.Insert(new Item("456799631", "ABS Function", 25, 12, Category.Brakes));

        }
    }
    #endregion

}

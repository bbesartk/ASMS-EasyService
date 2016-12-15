using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DataAccessLayer;
using ES.EntityLayer.Finance;
using ES.EntityLayer.Services;

namespace ES.BusinessLayer
{
    public class blInvoice
    {
        #region CRUD
        public static void InsertInvoice(Invoice invoice)
        {
            if (invoice != null)
                dalInvoice.Insert(invoice);
            else throw new Exception("Invalid Invoice");
        }

        public static void UpdateInvoice(Invoice invoice)
        {
            if (invoice != null)
                dalInvoice.Update(invoice);
            else throw new Exception("Invalid Incoice!");
        }

        public static void DeleteClient(string id)
        {
            if (id != "")
                dalInvoice.Remove(id);
            else throw new Exception("Invalid Id!");
        } 

        public static Invoice GetInvoice(string id)
        {
            return dalInvoice.GetSingleInvoice(id);
        }

        // A me kry edhe LotOfInvoice
        #endregion

        #region Query
        public static List<Invoice> GetAllInvoice()
        {
            return dalInvoice.GetAll();
        }

        public static decimal GetAllIncomes()
        {
            decimal total = 0;
            foreach (var item in GetAllInvoice())
            {
                total += item.Total;
            }
            return total;
        }

        public static decimal GetThisYearIncomes()
        {
            decimal total = 0;
            foreach (var item in GetAllInvoice())
            {
                if(item.DateOfBill.Year==DateTime.Now.Year)
                {
                    total += item.Total;
                }
            }
            return total;
        }

        public static decimal GetTodayIncomes()
        {
            decimal total = 0;
            foreach (var item in GetAllInvoice())
            {
                if(item.DateOfBill.Date==DateTime.Now.Date)
                {
                    total += item.Total;
                }
            }
            return total;
        }
       
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Finance;

namespace ES.DataAccessLayer
{
    public class dalInvoice
    {
        private static List<Invoice> ListOfInvoices = new List<Invoice>();

        public static void Insert(Invoice invoice)
        {
            ListOfInvoices.Add(invoice);
        }

        public static void Update(Invoice invoice)
        {
            foreach (Invoice oldInvoice in ListOfInvoices)
            {
                if (invoice.Id == oldInvoice.Id)
                {
                    
                }
            }
        }

        public static Invoice GetSingleInvoice(int id)
        {
            foreach (Invoice invoice in ListOfInvoices)
            {
                if (invoice.Id == id)
                    return invoice;
            }
            return null;
        }

        public static void Remove(int id)
        {
            Invoice invoice = GetSingleInvoice(id);
            ListOfInvoices.Remove(invoice);
        }

        public static List<Invoice> GetAll()
        {
            return ListOfInvoices;
        }
    }
}

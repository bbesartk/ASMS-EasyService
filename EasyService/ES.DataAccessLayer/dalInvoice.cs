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
            foreach (Invoice dbInvoice in ListOfInvoices)
            {
                if (dbInvoice.Id == invoice.Id)
                {
                    
                }
            }
        }

        public static Invoice GetSingleInvoice(string id)
        {
            foreach (Invoice invoice in ListOfInvoices)
            {
                if (invoice.Id == id)
                    return invoice;
            }
            return null;
        }

        public static void Remove(string id)
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

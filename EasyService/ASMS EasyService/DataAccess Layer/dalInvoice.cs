using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Finance;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalInvoice
    {
        private static List<Invoice> ListOfInvoices = new List<Invoice>();

        public static void Insert(Invoice bill)
        {
            ListOfInvoices.Add(bill);
        }

        public static void Delete(Invoice bill)
        {
            ListOfInvoices.Remove(bill);
        }


        public static List<Invoice> GetAll()
        {
            return ListOfInvoices;
        }
    }
}

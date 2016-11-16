using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Clients;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalCompany
    {
        private static List<Company> ListOfCompanys = new List<Company>();

        public static void Insert(Company company)
        {
            ListOfCompanys.Add(company);
        }

        public static void Delete(Company company)
        {
            ListOfCompanys.Remove(company);
        }

        public static List<Company> GetAll()
        {
            return ListOfCompanys;
        }
    }
}

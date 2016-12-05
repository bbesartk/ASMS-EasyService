using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Clients;

namespace ES.DataAccessLayer
{
    public class dalCompany
    {
        private static List<Company> ListOfCompanies = new List<Company>();

        public static void Insert(Company company)
        {
            ListOfCompanies.Add(company);
        }

        public static void Remove(string businessNumber)
        {
            var cmp = GetSingleCompany(businessNumber);
            ListOfCompanies.Remove(cmp);
        }


        public static List<Company> GetAll()
        {
            return ListOfCompanies;
        }


        public static void Update(Company company)
        {
            foreach (Company oldCompany in ListOfCompanies)
            {
                if (company.BusinessNumber == oldCompany.BusinessNumber)
                {
                    oldCompany.CompanyName = company.CompanyName;
                    oldCompany.ContactInfo = company.ContactInfo;
                }
            }
        }

        public static Company GetSingleCompany(string businessNumber)
        {
            foreach (Company company in ListOfCompanies)
            {
                if (company.BusinessNumber == businessNumber)
                    return company;
            }
            return null;
        }


    }
}

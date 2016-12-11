using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Clients;
using ES.DataAccessLayer;

namespace ES.BusinessLayer
{
    public class blCompany
    {
        #region CRUD
        public static void InserCompany(Company company)
        {
            if (company != null)
                dalCompany.Insert(company);
            else throw new Exception("Invalid Client!");
        }


        public static void UpdateClient(Company company)
        {
            if (company != null)
                dalCompany.Update(company);
            else throw new Exception("Invalid Client!");
        }


        public static void DeleteClient(string businessNumber)
        {
            if (String.IsNullOrEmpty(businessNumber))
                throw new Exception("Invalid business number!");
            else dalCompany.Remove(businessNumber);
        }


        public static Company GetCompany(string businessNumber)
        {
            return dalCompany.GetSingleCompany(businessNumber);
        }

        #endregion

        #region Query
        public static List<Company> GetAllCompanies()
        {
            return dalCompany.GetAll();
        }
        #endregion
    }
}

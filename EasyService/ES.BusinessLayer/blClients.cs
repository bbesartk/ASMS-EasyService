using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DataAccessLayer;
using ES.EntityLayer.Clients;
using ES.EntityLayer.General;

namespace ES.BusinessLayer
{
    public class blClients
    {

        #region CRUD
        public static void InsertClient(Client client)
        {
            if (client != null)
                dalClients.Insert(client);
            else throw new Exception("Invalid Client!");
        }

        public static void UpdateClient(Client client)
        {
            if( client != null)
            dalClients.Update(client);
            else throw new Exception("Invalid Client!");
        }

        public static void DeleteClient(int id)
        {
            if(id>0)
            dalClients.Remove(id);
            else throw new Exception("Invalid Id!");
        }

        public static Client GetClient(int id)
        {
            return dalClients.GetSingleClient(id);
        }

        public static void LotOfClient()
        {
            ContactInfo c1 = new ContactInfo("Kosova", "Prishtina", "+37745463373", "bbesart-k@msn.com");
            blClients.InsertClient(new Client("Besart", "Kuleta", c1));
            blClients.InsertClient(new Client("AAA", "C@", c1));
            blCompany.InserCompany(new Company("dsadas", "aaa", c1));
        }

        #endregion

        #region Query
        public static List<Client> GetAllClients()
        {
            return dalClients.GetAll();
        }

        private static bool AreValid(string name, string lastname, string email, string phoneNumber, string city, string address)
        {
            if (name != "" && lastname !="" && email != "" && phoneNumber != "" && city != "" && address !="")
                return true;
            else return false;
        }

        #endregion

    }
}

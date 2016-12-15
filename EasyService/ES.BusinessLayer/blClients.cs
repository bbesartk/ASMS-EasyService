using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DataAccessLayer;
using ES.EntityLayer.Clients;
using ES.EntityLayer.General;
using ES.EntityLayer.Employees;

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

        public static void DeleteClient(string id)
        {
            if(id!="")
            dalClients.Remove(id);
            else throw new Exception("Invalid Id!");
        }

        public static Client GetClient(string id)
        {
            return dalClients.GetSingleClient(id);
        }

        public static void LotOfClient()
        {
            ContactInfo c1 = new ContactInfo("Kosova", "Prishtina", "0442620629", "bbesart-k@msn.com");
            blClients.InsertClient(new Client("1234567899","Besart", "Kuleta", c1));
            blClients.InsertClient(new Client("1444467899","AAaaaaaA", "C@", c1));
            blCompany.InserCompany(new Company("dsadaaaas", "aaa", c1));
            blEmployees.InsertEmployees(new Mechanic("Kosova", "Prishtina", true, "abejjjaaaaa", "besartkuleta12", c1));
           
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

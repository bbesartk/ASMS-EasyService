using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DataAccessLayer;
using ES.EntityLayer.Clients;

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
            if(client != null)
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

       

        #endregion

        #region Query
        public static List<Client> GetAllClients()
        {
            return dalClients.GetAll();
        }
        #endregion

    }
}

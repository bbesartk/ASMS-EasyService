using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Clients;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalClients
    {
        private static List<Client> ListOfClients = new List<Client>();

        public static void Insert(Client client)
        {
            ListOfClients.Add(client);
        }

        public static void Delete(Client client)
        {
            ListOfClients.Remove(client);
        }

        public static List<Client> GetAll()
        {
            return ListOfClients;
        }
    }
}

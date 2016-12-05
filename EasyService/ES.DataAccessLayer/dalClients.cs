using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Clients;

namespace ES.DataAccessLayer
{
    public class dalClients
    {
        private static List<Client> ListOfClients = new List<Client>();

        public static void Insert(Client client)
        {
            ListOfClients.Add(client);
        }

        public static void Update(Client client)
        {
            foreach (Client oldClient in ListOfClients)
            {
                if(client.Id== oldClient.Id)
                {
                    oldClient.Name = client.Name;
                    oldClient.Lastname = client.Lastname;
                    oldClient.ContactInfo = client.ContactInfo;
                }
            }
        }

        public static Client GetSingleClient(int id)
        {
            
            foreach (Client client in ListOfClients)
            {
                if (client.Id == id)
                    return client;

            }
           return null;
        }

        public static Client GetSingleClient(string name, string lastname)
        {
            foreach (Client client in ListOfClients)
            {
                if (client.Name == name && client.Lastname == lastname)
                    return client;
            }
            return null;
        }

        public static void Remove(int id)
        {
            var client = GetSingleClient(id);
            ListOfClients.Remove(client);
        }

        public static List<Client> GetAll()
        {
            return ListOfClients;
        }
    }
}

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

        /// <summary>
        /// Kjo metode ben regjistrimin e nje klienti te ri
        /// </summary>
        /// <param name="client"></param>
        public static void Insert(Client client)
        {
            ListOfClients.Add(client);
        }

        /// <summary>
        /// Kjo metode ben perditesimin e te dhenave per klientin e caktuar
        /// </summary>
        /// <param name="client"></param>

        public static void Update(Client client)
        {
            foreach (Client dbClient in ListOfClients)
            {
                if (dbClient.Id == client.Id)
                {
                    dbClient.Name = client.Name;
                    dbClient.Lastname = client.Lastname;
                    dbClient.ContactInfo.City = client.ContactInfo.City;
                    dbClient.ContactInfo.Email = client.ContactInfo.Email;
                    dbClient.ContactInfo.PhoneNumber = client.ContactInfo.PhoneNumber;
                    dbClient.ContactInfo.Address = client.ContactInfo.Address;
                }
            }
        }

        /// <summary>
        /// Kjo metode na kthen (return) nje Client duke e kerkuar ne baz te ID-s
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static Client GetSingleClient(string id)
        {

            foreach (Client client in ListOfClients)
            {
                if (client.Id == id)
                    return client;

            }
            return null;
        }

        
        public static void Remove(string id)
        {
            Client client = GetSingleClient(id);
            ListOfClients.Remove(client);
        }

        /// <summary>
        /// Kjo metode i kthen te gjithe klientet e regjistruar
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetAll()
        {
            return ListOfClients;
        }
    }
}

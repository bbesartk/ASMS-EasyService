using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Clients
{
    class Client:Person
    {
        public int Id { get; private set; }
        static int _id = 0;

        public Client()
        {
            Id = ++_id;
        }
        public Client(string name, string lastname, string address, string phonenumber, string email):base(name,lastname,address,phonenumber,email)
        {
            Id = ++_id;
        }

    }
}

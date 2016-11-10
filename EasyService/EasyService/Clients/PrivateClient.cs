using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Clients
{
    class PrivateClient:Person
    {
        #region StaticMembers
        static int _id = 0;
        #endregion

        #region Properties
        public int Id { get; private set; }
        #endregion

        #region Constructors
        public PrivateClient()
        {
            Id = ++_id;
        }
        public PrivateClient(string name, string lastname, string address, string phonenumber, string email):base(name,lastname,address,phonenumber,email)
        {
            Id = ++_id;
        }
        #endregion

        #region Methods
        //Something to write
        #endregion

    }
}

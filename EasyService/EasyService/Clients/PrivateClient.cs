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
        public ContactInfo ContactInfo { get; set; }
        #endregion

        #region Constructors
        public PrivateClient()
        {
            Id = ++_id;
        }
        public PrivateClient(string name, string lastname, ContactInfo contactInfo, string email):base(name,lastname)
        {
            Id = ++_id;
            ContactInfo = contactInfo;
        }
        #endregion

        #region Methods
        //Something to write
        #endregion

    }
}

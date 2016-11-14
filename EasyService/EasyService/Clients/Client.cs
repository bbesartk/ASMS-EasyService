using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Clients
{
    class Client:Person
    {
        #region StaticMembers
        static int _id = 0;
        private ContactInfo _contactInfo;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                if (_contactInfo == null)
                    throw new ArgumentNullException("ContactInfo nuk duhet te jete negative");
            }
        }
     
        #endregion

        #region Constructors
        public Client()
        {
            Id = ++_id;
        }
        public Client(string name, string lastname, ContactInfo contactInfo, string email):base(name,lastname)
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

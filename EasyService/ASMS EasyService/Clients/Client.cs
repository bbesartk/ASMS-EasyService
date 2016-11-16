using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.General;

namespace ASMS_EasyService.Clients
{
    class Client:Person
    {
        #region StaticMembers
        private int _id = 0;
        #endregion

        #region PrivateMembers
        private ContactInfo _contactInfo;
        #endregion

        #region Properties
        public int Id { get; private set; }

        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                if (value !=null)
                    _contactInfo = value;
                else throw new ArgumentNullException("Contact Info nuk guxon te jete null!");
            }
        }
        #endregion

        #region Constructors

        public Client(string name, string lastname, ContactInfo contactInfo):base(name,lastname)
        {
            Id = ++_id;
            ContactInfo = contactInfo;
        }

        #endregion

        #region Methods

        #endregion
    }
}

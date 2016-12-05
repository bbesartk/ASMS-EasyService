using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;

namespace ES.EntityLayer.Clients
{
    public class Client:Person
    {
        #region StaticMembers
        private int _id = 0;
        #endregion

        #region Properties
        public int Id { get; private set; }

        public ContactInfo ContactInfo { get; set; }
        #endregion

        #region Constructors

        public Client(string name, string lastname, ContactInfo contactInfo) : base(name, lastname)
        {
            Id = ++_id;
            ContactInfo = contactInfo;
        }

        #endregion

        #region Methods

        #endregion
    }
}

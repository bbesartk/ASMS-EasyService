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
        #region Properties
        public string Id { get; set; }

        public ContactInfo ContactInfo { get; set; }
        #endregion

        #region Constructors

        public Client(string id,string name, string lastname, ContactInfo contactInfo) : base(name, lastname)
        {
            Id = id;
            ContactInfo = contactInfo;
        }
        public Client()
        {

        }

        #endregion

        #region Methods

        #endregion
    }
}

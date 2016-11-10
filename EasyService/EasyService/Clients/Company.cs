using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Clients
{
    class Company
    {
        #region Properties
        public string BusinessNumber { get; set; }
        public string Name { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public Contract Contract { get; set; }
        #endregion

        #region Constructors
        public Company(string businessNumber)
        {
            BusinessNumber = businessNumber;

        }

        public Company(string businessNumber,string name,ContactInfo contactInfo, Contract contract)
        {
            BusinessNumber = businessNumber;
            Name = name;
            ContactInfo = contactInfo;
            Contract = contract;
        }
        #endregion  

        #region Methods
        //
        #endregion
    }
}

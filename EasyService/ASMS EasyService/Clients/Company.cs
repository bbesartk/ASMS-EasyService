using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.General;

namespace ASMS_EasyService.Clients
{
    class Company
    {
        #region PrivateMembers
        private string _businessNumber;
        private string _companyName;
        private ContactInfo _contactInfo;
        #endregion

        #region Properties
        public string BusinessNumber
        {
            get { return _businessNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Company must have a business number!");
                else _businessNumber = value;
            }
        }


        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Company name can't be empty!");
                else _companyName = value;
            }
        }

        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                if (value ==null)
                    throw new ArgumentNullException("You must provide contact information!");
                else _contactInfo = value;
            }
        }
        #endregion

        #region Constructors
        public Company(string businessNumber, string companyName, ContactInfo contactInfo)
        {
            BusinessNumber = businessNumber;
            CompanyName = companyName;
            ContactInfo = contactInfo;
        }
        #endregion

        #region Methods

        #endregion
    }
}

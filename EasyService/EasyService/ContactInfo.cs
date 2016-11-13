using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService
{
    class ContactInfo
    {
        #region PrivateMembers
        private string _city;
        private string _address;
        private string _phoneNumber;
        private string _email;
        #endregion

        #region Properties
        public string City { get { return _city; }
            set
            {
                if (_city != String.Empty)
                {
                    _city = value;
                }
                else
                {
                    throw new Exception("Shkruani Qytetin");
                }
            }
        }
        public string Address { get { return _address; }
            set
            {
                if (_address != String.Empty)
                {
                    _address = value;
                }
                else
                {
                    throw new Exception("Shkruani addressen");
                }
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != String.Empty)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception("Shkruani numrin e telefonit");
                }
            }
        }
        public string Email { get; set; }
        
           
        #endregion

            #region Constructors
        public ContactInfo()
        {

        }

        public ContactInfo(string city, string address, string phoneNumber, string email)
        {
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        public string City
        {
            get { return _city; }
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
        public string Address
        {
            get { return _address; }
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
                if (IsPhoneNumber(value))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception("Formati i numrit te telefonit nuk ishte valid");
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (IsEmail(value))
                {
                    _email = value;
                }
                else throw new Exception("Formati i email adreses nuk eshte i sakt.");
            }
            
        }


        #endregion

        #region Constructors

        public ContactInfo(string city, string address, string phoneNumber, string email)
        {
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        #endregion
        #region PrivateMethods

        private bool IsEmail(string email)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
            if (rgx.IsMatch(email))
                return true;
            else return false;
        }


        private bool IsPhoneNumber(string phone)
        {
            Regex rgx = new Regex(@"^(\+[0-9]{9,15})$");
            if (rgx.IsMatch(phone))
                return true;
            else return false;
        }
        #endregion

    }
}

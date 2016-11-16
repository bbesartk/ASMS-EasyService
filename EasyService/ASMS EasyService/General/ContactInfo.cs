using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ASMS_EasyService.General
{
    class ContactInfo
    {

        #region StaticMembers

        #endregion

        #region PrivateMembers
        private string _city;
        private string _email;
        private string _phoneNumber;
        private string _address;
        #endregion

        #region Properties
        public string City
        {
            get { return _city; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("City can't be empty!");
                else _city = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Address can't be empty!");

                else _address = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Email can't be empty!");

                else if (IsPhoneNumber(value))  _email = value;

                else throw new Exception("Invalid Email format!");
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("The phone number can't be empty!");

                else if (IsPhoneNumber(value))  _phoneNumber = value;

                else throw new Exception("Invalid PhoneNumber format!");
            }
        }
        #endregion

        #region Constructors
        public ContactInfo(string city, string address, string phonenumber, string email)
        {
            City = city;
            Address = address;
            PhoneNumber = phonenumber;
            Email = email;
        }
        #endregion

        #region Methods
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

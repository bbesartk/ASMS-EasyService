using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.General;

namespace ASMS_EasyService.Employees
{
    class Employee:Person
    {
        #region StaticMembers
        private int _id = 0;
        #endregion

        #region PrivateMembers
        private string _password;
        private string _role;
        private ContactInfo _contactInfo;
        #endregion

        #region Properties
        public string Id { get; private set; }

        public string Role
        {
            get { return _role; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a role!");
                else _role = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length > 4 && value.Length < 15)
                    _password = value;
                else throw new Exception("You must provide a password!");
            }
        }

        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("You must provide contact information for this employee!");
                else _contactInfo = value;
            }
        }
        #endregion

        #region Constructors
        public Employee(string name, string lastname, bool isMale, ContactInfo contactInfo, string password, string role):base(name,lastname,isMale)
        {
            Id = ++_id + role;
            ContactInfo = contactInfo;
            Password = password;
            Role = role;
            
        }
        #endregion

        #region Methods

        #endregion
    }
}

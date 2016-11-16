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
        private int _id = DateTime.Now.Year;
        #endregion

        #region PrivateMembers
        private string _password;
        private char _role;
        private ContactInfo _contactInfo;
        #endregion

        #region Properties
        public string Id { get; private set; }

        public char Role
        {
            get { return _role; }
            set
            {
                if (Char.IsLetter(value))
                    _role = value;
                else throw new Exception("You must provide a role!");
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
        public Employee(string name, string lastname, bool isMale, ContactInfo contactInfo, string password, char role):base(name,lastname,isMale)
        {
            Id = GenerateId(role);
            ContactInfo = contactInfo;
            Password = password;
            Role = role;
            
        }
        #endregion

        #region Methods
        private string GenerateId(char role)
        {
            int id = ++_id;
            return id.ToString() + role;
        }
        #endregion
    }
}

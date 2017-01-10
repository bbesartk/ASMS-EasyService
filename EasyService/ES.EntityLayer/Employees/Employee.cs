using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;

namespace ES.EntityLayer.Employees
{
    public abstract class Employee : Person
    {

        #region AbstractMember
        abstract public string Id { get; set; }
        private string _password;
        private string _username;
        #endregion

        #region Properties
        public ContactInfo ContactInfo { get; set; }

        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length > 4 && value.Length < 15)
                    _username = value;
                else throw new Exception("You must provide a username!");
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

        #endregion

        #region Constructors

        public Employee(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Employee()
        {

        }
        public Employee(string name, string lastname, bool isMale, string username, string password, ContactInfo contactInfo) : base(name, lastname, isMale)
        {
            Username = username;
            Password = password;
            ContactInfo = contactInfo;
        }
        #endregion

        #region Methods
        abstract public string GenerateId();

        #endregion
    }
}

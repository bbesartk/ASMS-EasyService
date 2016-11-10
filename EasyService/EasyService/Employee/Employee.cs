using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Employee
{
    class Employee:Person
    {
        #region StaticMembers
        static int _id = 2016;
        #endregion

        #region Properties

        public string Id { get; private set; }
        public string Password { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public string Role { get; set; }

        #endregion

        #region Constructors
        public Employee(string role)
        {
            Id = ++_id + role;
        }
        public Employee(string name, string lastname, bool isMale,ContactInfo contactInfo, string password,string role) : base(name, lastname, isMale)
        {
            Id = ++_id+role;
            IsMale = isMale;
            Password = password;
        }

        #endregion

        #region Methods
        //Something to write
        #endregion



    }
}

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
        static int _id = 0;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public bool IsMale { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructors
        public Employee()
        {
            Id = ++_id;
        }
        public Employee(string name, string lastname, bool isMale, string address, string phonenumber, string email, string password) : base(name, lastname, address, phonenumber, email)
        {
            Id = ++_id;
            IsMale = isMale;
            Password = password;
        }

        #endregion

        #region Methods
        //Something to write
        #endregion



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService
{
    class Person
    {

        #region Properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructors
        public Person()
        {
            //default constructor
        }
        public Person(string name, string lastname, string address, string phonenumber, string email)
        {
            Name = name;
            LastName = lastname;
            Address = address;
            PhoneNumber = phonenumber;
            Email = email;
        }
        #endregion

        #region Methods
        //Something to write
        #endregion
    }
}

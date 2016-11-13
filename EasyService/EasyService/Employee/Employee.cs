﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Employee
{
    class Employee : Person
    {
        #region StaticMembers
        static int _id = DateTime.Now.Year;
        #endregion

        #region PrivateMembers
        private string _password;
        private ContactInfo _contactInfo;
        private string _role;
        #endregion

        #region Properties

        public string Id { get; private set; }
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password.Length > 4)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Gjasia e Passwordit duhet te jet mbi 4 karaktere");
                }
            }
        }
        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                if (_contactInfo != null)
                {
                    _contactInfo = value;
                }
                else
                {
                    throw new Exception("Kontakt info nuk duhet te jet i zbrazet");
                }
            }
        }


        public string Role { get { return _role; }
            set
            {
                if (_role != String.Empty)
                {
                    _role = value;
                }
                else
                {
                    throw new Exception("Roli nuk guxon te jet i zbrazet");
                }
            }
        }

        #endregion

        #region Constructors
        public Employee(string role)
        {
            Id = ++_id + role;
        }
        public Employee(string name, string lastname, bool isMale, ContactInfo contactInfo, string password, string role) : base(name, lastname, isMale)
        {
            Id = ++_id + role;
            IsMale = isMale;
            ContactInfo = contactInfo;
            Password = password;
        }

        #endregion

        #region Methods
        //Something to write
        #endregion



    }
}

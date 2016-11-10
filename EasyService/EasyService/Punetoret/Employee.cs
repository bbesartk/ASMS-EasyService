﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Employee
{
    class Employee:Person
    {
        public int Id { get; set; }
        public bool IsMale { get; set; }
        public string Password { get; set; }
        private static int _id = 0;


        public Employee()
        {
            Id = ++_id;

        }
        public Employee(string name, string lastname, string address, string phonenumber, string email,bool isMale,string password):base(name,lastname,address,phonenumber,email)
        {
            Id = ++_id;
            IsMale = isMale;
            Password = password;
        }
    }
}
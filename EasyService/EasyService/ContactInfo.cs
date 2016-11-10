﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService
{
    class ContactInfo
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public ContactInfo()
        {

        }

        public ContactInfo(string city, string address, string phoneNumber, string email)
        {
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}

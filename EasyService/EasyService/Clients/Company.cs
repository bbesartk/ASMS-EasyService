﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Companys
{
    class Company
    {
        #region Properties
        public int BusinessNumber { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Contract Contract { get; set; }
        #endregion

        #region Constructors
        public Company()
        {

        }
        #endregion  

        #region Methods
        //
        #endregion
    }
}
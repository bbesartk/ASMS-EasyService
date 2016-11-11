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
        public bool IsMale { get; set; }
        
        #endregion

        #region Constructors
        public Person()
        {
            //default constructor
        }
        public Person(string name, string lastname, bool isMale)
        {
            Name = name;
            LastName = lastname;
            IsMale = isMale;
        }

        public Person(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        #endregion

        #region Methods
        //Something to write
        #endregion
    }
}

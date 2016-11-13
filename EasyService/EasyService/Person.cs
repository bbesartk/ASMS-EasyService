using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService
{
    class Person
    {
        #region PrivateMembers
        private string _name;
        private string _lastName;

        #endregion

        #region Properties
        public string Name { get { return _name; }
            set
            {
                if (value != String.Empty)
                {
                    _name = value;

                }
                else
                {
                    throw new Exception("Shkruaje Emrin");
                }
            }
        }
        public string LastName { get { return _lastName; }
            set
            {
                if (value != String.Empty)
                {
                    _lastName = value;

                }
                else
                {
                    throw new Exception("Shkruaje Mbiemrin");
                }
            }
        }
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

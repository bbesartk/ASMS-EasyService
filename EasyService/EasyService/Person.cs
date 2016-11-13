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
        private bool _isMale;

        #endregion

        #region Properties
        public string Name { get { return _name; }
            set
            {
                if (_name != String.Empty)
                {
                    _name = value;

                }
                else
                {
                    throw new Exception("Shkruj Emrin");
                }
            }
        }
        public string LastName { get { return _lastName; }
            set
            {
                if (_lastName != String.Empty)
                {
                    _lastName = value;

                }
                else
                {
                    throw new Exception("Shkruj Mbiemrin");
                }
            }
        }
        public bool IsMale { get { return _isMale; }
            set
            {
                if (_isMale == (value))
                {
                    _isMale = value;

                }
                else
                {
                    throw new Exception("Shkruj Emrin");
                }
            }
        }
        
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

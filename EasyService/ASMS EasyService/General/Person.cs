using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS_EasyService.General
{
    class Person
    {
        #region StaticMembers

        #endregion

        #region PrivateMembers
        private string _name;
        private string _lastName;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be empty!");
                }
                else _name = value;
            }
        }

        public string Lasname
        {
            get { return _lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Lastname can't be empty!");
                }
                else _lastName = value;
            }
        }

        public bool IsMale { get; set; }
        #endregion

        #region Constructors
        public Person(string name, string lastname, bool isMale)
        {
            Name = name;
            Lasname = lastname;
            IsMale = isMale;
        }

        public Person(string name, string lastname)
        {
            Name = name;
            Lasname = lastname;
        }
        #endregion

        #region Methods
        //Something to write
        #endregion
    }
}

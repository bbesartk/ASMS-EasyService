using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.General
{
    public class Person
    {
        #region PrivateMembers
        private string _name;
        private string _lastName;
        #endregion

        #region Properties
        protected bool IsMale { get; set; }

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

        public string Lastname
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

        #endregion

        #region Constructors
        public Person()
        {

        }

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public Person(string name, string lastname, bool isMale) : this(name, lastname)
        {
            IsMale = isMale;
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return Name + " " + Lastname;
        }
        #endregion
    }
}

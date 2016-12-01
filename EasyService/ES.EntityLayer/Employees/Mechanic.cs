using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;

namespace ES.EntityLayer.Employees
{
    class Mechanic:Employee
    {
        #region PrivateMembers
        static int _id = DateTime.Now.Year;
        #endregion

        #region Properties
        public override string Id { get; set; }
        #endregion

        #region Constructors

        public Mechanic(string name, string lastname, bool isMale, string username, string password, ContactInfo contactInfo):base(name,lastname,isMale,username,password,contactInfo)
        {
            Id = GenerateId();
        }
        #endregion

        #region Methods
       public override string GenerateId()
        {
            int id = ++_id;
            return id.ToString() + "M";
        }
        #endregion
    }
}

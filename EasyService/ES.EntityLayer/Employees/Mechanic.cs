using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;
using System.Windows.Forms;

namespace ES.EntityLayer.Employees
{
    public class Mechanic:Employee,IAccess
    {
        #region PrivateMembers
        static int _id = DateTime.Now.Year;
        #endregion

        #region Properties
        public override string Id { get; set; }

        public Access Access { get; set; } = new Access(true, true, true, false, false, false, false, false);
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

        public override string ToString()
        {
            return Name;
        }

        public void DisplayMessage()
        {
            MessageBox.Show("You have limited access!");
        }

        #endregion
    }
}

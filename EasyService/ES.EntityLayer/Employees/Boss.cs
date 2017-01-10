using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;

namespace ES.EntityLayer.Employees
{
   public class Boss : Employee,IAccess
    {
        static int _id =0;

        public Boss(string user, string pw)
        {
            Username = user;
            Password = pw;
        }

        public Access Access { get; set; } = new Access(true, true, true, true, true, true, true, true);

        public override string Id { get; set; }

        public void DisplayMessage()
        {
            
        }

        public override string GenerateId()
        {
            int id = ++_id;
            return id.ToString() + "A";
        }

    }
}

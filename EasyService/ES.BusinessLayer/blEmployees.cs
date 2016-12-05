using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Employees;
using ES.DataAccessLayer;

namespace ES.BusinessLayer
{
    class blEmployees
    {
        #region CRUD
        public static void InsertEmployees(Mechanic mechanic)
        {
            if (mechanic != null)
                dalEmployees.Insert(mechanic);
            else throw new Exception("Invalid Employees");
        }

        public static void UpdateEmployees(Mechanic mechanic)
        {
            if (mechanic != null)
                dalEmployees.Update(mechanic);
            else throw new Exception("Invalid Employees");
        }

        public static void DeleteEmployees(string id)
        {
            if (id != null)
                dalEmployees.Remove(id);
            else throw new Exception("Invalid Id!");
        }

        public static Mechanic GetMechanic(string id)
        {
            return dalEmployees.GetSingelMechanic(id);
        }


        #endregion

        #region Query
        public static List<Mechanic> GetAllMechanics()
        {
            return dalEmployees.GetAll();
        }

        #endregion
    }
}

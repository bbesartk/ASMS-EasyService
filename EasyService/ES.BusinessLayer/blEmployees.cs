using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Employees;
using ES.DataAccessLayer;
using ES.EntityLayer.Vehicle;

namespace ES.BusinessLayer
{
    public class blEmployees
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
            if (String.IsNullOrEmpty(id))
                throw new Exception("Invalid Id!");
            else dalEmployees.Remove(id);
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

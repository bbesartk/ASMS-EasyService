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

        public static void InsertEmployees(Boss boss)
        {
            dalEmployees.InsertAdmin(boss);
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

        public static Boss GetAdmin(string id)
        {
            foreach (var item in dalEmployees.GetAllAdmin())
            {
                if (item.Id == id)
                    return item;

            }
            return null;
        }

        #endregion

        #region Query
        public static List<Mechanic> GetAllMechanics()
        {
            return dalEmployees.GetAllMechanics();
        }

        public static List<Employee> GetAllEmployees()
        {
            return dalEmployees.GetAll();
        }

        #endregion
    }
}

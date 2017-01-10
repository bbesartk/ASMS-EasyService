using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Employees;

namespace ES.DataAccessLayer
{
     public class dalEmployees
      {
        private static List<Mechanic> _listOfMechanic = new List<Mechanic>();

        private static List<Employee> _listOfEmployees = new List<Employee>();

        private static List<Boss> _listOfAdmin = new List<Boss>();

        public static void Insert(Mechanic mechanic)
        {
            _listOfMechanic.Add(mechanic);
        }

        public static void Update(Mechanic mechanic)
        {
            foreach (Mechanic oldMechanic in _listOfMechanic)
            {
                if (mechanic.Id == oldMechanic.Id)
                {
                    oldMechanic.Name = mechanic.Name;
                    oldMechanic.Lastname = mechanic.Lastname;
                    oldMechanic.Username = mechanic.Password;
                    oldMechanic.Password = mechanic.Password;
                }
               
            }
        }

        public static Mechanic GetSingelMechanic(string id)
        {
            foreach (Mechanic mechanic in _listOfMechanic)
            {
                if (mechanic.Id == id)
                    return mechanic;
            }
            return null;
        }

        public static void InsertAdmin(Boss boss)
        {
            _listOfAdmin.Add(boss);
        }

        public static List<Boss> GetAllAdmin()
        {
            return _listOfAdmin;
        }


        public static void Remove(string id)
        {
            Mechanic mechanic = GetSingelMechanic(id);
            _listOfMechanic.Remove(mechanic);
        }
        public static List<Employee> GetAll()
        {
            List<Employee> emp = new List<Employee>();
            foreach (var item in _listOfMechanic)
            {
                emp.Add((Employee)item);
            }
            foreach (var item in _listOfAdmin)
            {
                emp.Add((Employee)item);
            }
            return emp;

        }

        private static int CountEmployees()
        {
            return _listOfAdmin.Count + _listOfMechanic.Count;
        }

        public static List<Mechanic> GetAllMechanics()
        {
            return _listOfMechanic;
        }
    }
}

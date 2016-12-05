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

        public static void Remove(string id)
        {
            Mechanic mechanic = GetSingelMechanic(id);
            _listOfMechanic.Remove(mechanic);
        }
        public static List<Mechanic> GetAll()
        {
            return _listOfMechanic;
        }
    }
}

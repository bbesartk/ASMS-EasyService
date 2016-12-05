using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Vehicle;

namespace ES.DataAccessLayer
{
    public class dalVehicle
    {
        private static List<Vehicle> _listOfVehicle = new List<Vehicle>();

        public static void Insert(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                _listOfVehicle.Add(vehicle);
            }
        }

        public static List<Vehicle> GetAll()
        {
            return _listOfVehicle;
        }

        public static Vehicle GetSingleVehicle(string licensePlate)
        {
            foreach (Vehicle vehicle in _listOfVehicle)
            {
                return vehicle;
            }
            return null;
        }
    }
}

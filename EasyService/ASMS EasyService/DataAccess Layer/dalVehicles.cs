using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Vehicles;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalVehicles
    {
        private static List<Vehicle> ListOfVehicles = new List<Vehicle>();

        public static void Insert(Vehicle vehicle)
        {
            ListOfVehicles.Add(vehicle);
        }

        public static void Delete(Vehicle vehicle)
        {
            ListOfVehicles.Remove(vehicle);
        }

        public static List<Vehicle> GetAll()
        {
            return ListOfVehicles;
        }
    }
}

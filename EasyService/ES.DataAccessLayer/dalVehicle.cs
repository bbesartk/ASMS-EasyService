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

        public static void Update(Vehicle vehicle)
        {
            foreach (Vehicle registerdVh in _listOfVehicle)
            {
                if(registerdVh.LicensePlate==vehicle.LicensePlate)
                {
                    registerdVh.LicensePlate = vehicle.LicensePlate;
                    registerdVh.Vin = vehicle.Vin;
                    registerdVh.Model = vehicle.Model;
                    registerdVh.Type = vehicle.Type;
                    registerdVh.ProductionYear = vehicle.ProductionYear;
                    registerdVh.CubicC = vehicle.CubicC;
                    registerdVh.Client = vehicle.Client;
                    registerdVh.Company = vehicle.Company;
                    registerdVh.IsSubscribed = vehicle.IsSubscribed;
                }
            }
        }


    }
}

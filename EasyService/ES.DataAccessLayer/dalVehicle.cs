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
        private static List<Car> _listOfCars = new List<Car>();

        public static void Insert(Car car)
        {
            if (car != null)
            {
                _listOfCars.Add(car);
            }
        }

        public static Car GetSingleCar(string licensePlate)
        {
            foreach (Car car in _listOfCars)
            {
                return car;
            }
            return null;
        }
    }
}

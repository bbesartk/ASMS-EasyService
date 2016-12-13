using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Vehicle;
using ES.DataAccessLayer;
using ES.EntityLayer.Clients;
using ES.EntityLayer.Employees;


namespace ES.BusinessLayer
{
    public class blVehicle
    {
        #region CRUD
        public static void InsertVehicle(Vehicle vehicle)
        {
            if (vehicle != null)
                dalVehicle.Insert(vehicle);
            else throw new Exception("Invalid Vehicle!");
        }

        public static void UpdateVehicle(Vehicle vehicle)
        {
            if (vehicle != null)
                dalVehicle.Update(vehicle);
            else throw new Exception("Invalid Vehicle!");
        }

      

        public static Vehicle GetVehicle(string licensePlate)
        {
            return dalVehicle.GetSingleVehicle(licensePlate);
        }

        public static void LotOfVehicle()
        {
            
            blVehicle.InsertVehicle(new Vehicle("01-111-AI", 2016, "Mustang", "Shelby", 5200));
            blVehicle.InsertVehicle(new Vehicle("01-123-BC", 2013, "Mercedes Benz", "C", 2200));
            blVehicle.InsertVehicle(new Vehicle("01-456-DG", 2003, "Volswagen", "Golf", 1900));

        }


        #endregion

        #region Query

        public static List<Vehicle> GetAll()
        {
            return dalVehicle.GetAll();
        }

        public static List<Vehicle> GetAllSubscribed()
        {
            List<Vehicle> _allSubs = new List<Vehicle>();
            foreach (var item in GetAll())
            {
                if (item.IsSubscribed == true)
                    _allSubs.Add(item);
            }
            return _allSubs;
        }

        public static List<Vehicle> GetAllFromClient(Client client)
        {
            List<Vehicle> _allFromClient = new List<Vehicle>();
            foreach (var item in GetAll())
            {
                if(item.Client != null)
                {
                    _allFromClient.Add(item);
                }
            }
            return _allFromClient;
        }


        public static List<Vehicle> GetAllFromClient(Company company)
        {
            List<Vehicle> _allFromCompany = new List<Vehicle>();
            foreach (var item in GetAll())
            {
                if (item.Client == null)
                {
                    _allFromCompany.Add(item);
                }
            }
            return _allFromCompany;
        }

        //Palidhje e menaxhume :)
        public static List<Vehicle> ServicedBy(Mechanic mch)
        {
            List<Vehicle> servicedBy = new List<Vehicle>();

            for (int i = 0; i < GetAll().Count(); i++)
            {
                if (GetAll()[i].ServiceList[i].ServicedBy.Id == mch.Id)
                    servicedBy.Add(GetAll()[i]);
            }

            return servicedBy;
        }

        #endregion
        }
}

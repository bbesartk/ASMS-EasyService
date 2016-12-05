using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Vehicles;
using ASMS_EasyService.Clients;

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

        public static void Unsubscribe(Vehicle vh)
        {
            vh.IsSubscribed = false;
        }

        public static List<Vehicle> GetAllSubscribed()
        {
           List<Vehicle> subscribedVehicle = new List<Vehicle>();
            var test = ListOfVehicles.Where(i => i.IsSubscribed==true);
            var sum = ListOfVehicles.Sum(i => i.ProductionYear);
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.IsSubscribed == true)
                    subscribedVehicle.Add(vh);
            }
            return subscribedVehicle;
        }

        public static bool IsValidKm(List<Service> listservice, double km)
        {
            double servicedKm = listservice[listservice.Count - 1].ServicedKm;
            if (km > servicedKm)
                return true;
            else return false;
        }

        public static List<Vehicle> GeAllReadyForService()
        {
            List<Vehicle> readyForService = new List<Vehicle>();
            foreach (Vehicle vh in GetAllSubscribed())
            {
                TimeSpan daysSinceLastService = DateTime.Now.Date - GetLastService(vh).DateOfService.Date;
                if (daysSinceLastService.TotalDays > 90)
                    readyForService.Add(vh);
            }
            return readyForService;
        }



        public static Service GetLastService(Vehicle vh)
        {
            return vh.ServiceList[vh.ServiceList.Count - 1];
        }


        public static List<Vehicle> GetAllFromCompany(Company cmp)
        {
            List<Vehicle> companyCars = new List<Vehicle>();
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.Company == cmp)
                    companyCars.Add(vh);
            }
            return companyCars;
        }

        public static List<Vehicle> GetAllFromCompany(string businessNumber)
        {
            List<Vehicle> companyCars = new List<Vehicle>();
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.Company.BusinessNumber == businessNumber)
                    companyCars.Add(vh);
            }
            return companyCars;
        }

        public static List<Vehicle> GetAllFromClient(Client client)
        {
            List<Vehicle> clientCars = new List<Vehicle>();
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.Client == client)
                    clientCars.Add(vh);
            }
            return clientCars;
        }

        public static List<Vehicle> GetAllFromClient(int clientId)
        {
            List<Vehicle> clientCars = new List<Vehicle>();
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.Client.Id == clientId)
                    clientCars.Add(vh);
            }
            return clientCars;
        }

        public static List<Vehicle> GetAllFromClient(string name, string lastname)
        {
            List<Vehicle> clientCars = new List<Vehicle>();
            foreach (Vehicle vh in ListOfVehicles)
            {
                if (vh.Client.Name == name && vh.Client.Lasname==lastname)
                    clientCars.Add(vh);
            }
            return clientCars;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Vehicle;
using ES.DataAccessLayer;
using ES.EntityLayer.Clients;
using ES.EntityLayer.Employees;
using ES.EntityLayer.General;


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

            
            ContactInfo c1 = new ContactInfo("Prishtine", "Kosove", "+37745363373", "bbesartk@msn.com");
            blVehicle.InsertVehicle(new Vehicle("01-111-AI","23234234234", 2016, "Mustang", "Shelby", 5200));
            blVehicle.InsertVehicle(new Vehicle("01-123-BC", "23234234234", 2013, "Mercedes Benz", "C", 2200));
            blVehicle.InsertVehicle(new Vehicle("01-456-DG", "23234234234", 2003, "Volswagen", "Golf", 1900));

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
                if (item.Client != null)
                {
                    _allFromClient.Add(item);
                }
            }
            return _allFromClient;
        }


        public static List<Vehicle> GetAllFromCompany(Company company)
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

        public static List<Vehicle> GeAllReadyForService()
        {
            List<Vehicle> readyForService = new List<Vehicle>();
            foreach (Vehicle vh in GetAllSubscribed())
            {
                if (blServices.GetLastService(vh) != null)
                {
                    TimeSpan daysSinceLastService = DateTime.Now.Date - blServices.GetLastService(vh).DateOfService.Date;
                    if (daysSinceLastService.TotalDays >= 100)
                        readyForService.Add(vh);
                }
                
            }

            return readyForService;
        }

        public static int CalculateSmallService(Vehicle vehicle)
        {
            if(blServices.GetLastService(vehicle) != null)
            {
                TimeSpan daysSinceLastService = DateTime.Now.Date - blServices.GetLastService(vehicle).DateOfService.Date;
                return int.Parse(daysSinceLastService.TotalDays.ToString());
            }
            return 0;
        }



        public static List<Vehicle> ServicedBy(string mechanicId)
        {
            List<Vehicle> servicedVehicles = new List<Vehicle>();
            var mechanic = blEmployees.GetMechanic(mechanicId);
            foreach (var item in blInvoice.GetAllInvoice())
            {
                if (item.ServicedBy == mechanic)
                {
                    servicedVehicles.Add(item.ServicedVehicle);
                }
            }
            return servicedVehicles;
        }

        #endregion

        #region CarLists
        public static List<CarType> listCarType = new List<CarType>
        {
            new CarType(1,"Audi"), new CarType(2,"Alfa Romeo"),new CarType(3,"BMW"),new CarType(4,"Cadillac"),new CarType(5,"Chevorlet"),new CarType(6,"Chrysler"),new CarType(7,"Dodge"),new CarType(8,"Ford"),new CarType(9,"Land Rover"),new CarType(10,"Mercedes-Benz"),new CarType(11,"Volkswagen"),new CarType(12,"Volvo")
        };

        public static List<CarModel> listCarModel = new List<CarModel>
        {
            new CarModel(1,"A1"),new CarModel(1,"A3"),new CarModel(1,"A4"),new CarModel(1,"A5"),new CarModel(1,"A6"),new CarModel(1,"A7"),new CarModel(1,"A8"),new CarModel(1,"Q3"),new CarModel(1,"Q5"),new CarModel(1,"Q7"),new CarModel(1,"TT"),
            new CarModel(2,"4C"),
            new CarModel(3,"2 Series"),new CarModel(3,"3 Series"),new CarModel(3,"4 Series"),new CarModel(3,"5 Series"),new CarModel(3,"6 Series"),new CarModel(3,"7 Series"),new CarModel(3,"i3"),new CarModel(3,"i8"),new CarModel(3,"M2"),new CarModel(3,"M3"),new CarModel(3,"M4"),new CarModel(3,"M5"),new CarModel(3,"M6"),new CarModel(3,"X1"),new CarModel(3,"X3"),new CarModel(3,"X4"),new CarModel(3,"X5"),new CarModel(3,"X6"),new CarModel(3,"Z4"),
            new CarModel(4,"ATS"),new CarModel(4,"CT6"),new CarModel(4,"CTS"),new CarModel(4,"ELR"),new CarModel(4,"Escalade"),new CarModel(4,"SRX"),new CarModel(4,"XTS"),
            new CarModel(5,"Camaro"),new CarModel(5,"Corveto"),new CarModel(5,"Impala"),new CarModel(5,"Suburban"),new CarModel(5,"Tahore"),new CarModel(5,"Volt"),
            new CarModel(6,"200"),new CarModel(6,"300"),new CarModel(6,"Town & Contry"),
            new CarModel(7,"Challenger"),new CarModel(7,"Charger"),new CarModel(7,"Dart"),new CarModel(7,"Viper"),
            new CarModel(8,"Focus"),new CarModel(8,"Fiest"),new CarModel(8,"Mustang"),new CarModel(8,"Taurus"),new CarModel(8,"Mondeo"),new CarModel(8,"F-150"),
            new CarModel(9,"Range Rover"),new CarModel(9,"Evoque"),new CarModel(9,"Voque"),new CarModel(9,"Sport"),
            new CarModel(10,"A-Class"),new CarModel(10,"B-Class"),new CarModel(10,"C-Class"),new CarModel(10,"E-Class"),new CarModel(10,"G-Class"),new CarModel(10,"GLE-Class"),new CarModel(10,"GLC-Class"),new CarModel(10,"GL-Class"),new CarModel(10,"GlA-Class"),new CarModel(10,"S-Class"),new CarModel(10,"ML-Class"),new CarModel(10,"X-Class"),
            new CarModel(11,"Beetel"),new CarModel(11,"Golf"),new CarModel(11,"Passat"),new CarModel(11,"Jet"),new CarModel(11,"Tiguan"),new CarModel(11,"Turan"),new CarModel(11,"Tuareg"),new CarModel(11,"Sharan"),
            new CarModel(12,"V40"),new CarModel(12,"V55"),new CarModel(12,"V60"),new CarModel(12,"V90")
        };

        public static int GetCarId(string name)
        {
            foreach (var item in listCarType)
            {
                if (item.Name == name)
                    return item.Id;
            }
            return -1;
        }

        public static List<CarModel> GetCarModels(int carId)
        {
            List<CarModel> listModelByCar = new List<CarModel>();
            foreach (var item in listCarModel)
            {
                if (carId == item.CarID)
                    listModelByCar.Add(item);
            }
            return listModelByCar;
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Clients;
using EasyService.DataAccess;


namespace EasyService.Autos
{
    class Vehicle
    {
        #region private variables
        private string _licensePlate;
        private int _productionYear;
        private string _type;
        private string _model;
        private double _currentKM;
        private int _cubicC;
        private Company company;
        private Client client;
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value != String.Empty)
                {
                    _licensePlate = value;
                }
                else
                {
                    throw new Exception("Ju Lutem mbush Targat e Vetures");
                }
            }
        }


        public int ProductionYear
        {
            get { return _productionYear; }
            set
            {
                if (value >= 1950 || value <= DateTime.Now.Year) _productionYear = value;
                else
                    throw new Exception("Viti i prodhimit eshte jo valid");
            }
        }


        public string Type
        {
            get { return _type; }
            set
            {
                if (value != String.Empty) _type = value;
                else throw new Exception("Ju Lutem shkruaj Tipin ");
            }
        }


        public string Model
        {
            get { return _model; }
            set
            {
                if (value != String.Empty) _model = value;
                else throw new Exception("Ju Lutem shkruaj Modelin");
            }
        }


        public int CubicCentimeters
        {
            get { return _cubicC; }
            set
            {
                if (value >= 600 && value < 30000)
                    _cubicC = value;
                else throw new Exception("Kubikazha eshte jo valide!");
            }
        }


        public double CurrentKM
        {
            get { return _currentKM; }
            set{
                if (HasService()==false && value>0)
                {
                    _currentKM = value;
                }
                else if(HasService() && IsValidKm(value))
                {
                    _currentKM = value;
                } 
                else throw new Exception("Kilometrat jan invalid");
            }
        }


        public Company Company
        {
            get { return company; }
            set { if (client == null) company = value; }
        }

        public Client Client
        {
            get { return client; }
            set { if (company == null) client = value; }
        }
        public List<Service> ServiceList { get; set; }//history of services
        public bool IsSubscribed { get; set; }

        #endregion

        #region Conctructors

        public Vehicle()
        {

        }
        public Vehicle(string licensePlate, int productionYear, string type, string model, int cubicCm, double currentKm, Company company, List<Service> serviceList)
        {
            LicensePlate = licensePlate;
            ProductionYear = productionYear;
            Type = type;
            Model = model;
            CubicCentimeters = cubicCm;
            CurrentKM = currentKm;
            Company = company;
            ServiceList = serviceList;
            IsSubscribed = true;

        }

        public Vehicle(string licensePlate, int productionYear, string type, string model, int cubicCm, double currentKm, Client client, List<Service> serviceList)
        {
            LicensePlate = licensePlate;
            ProductionYear = productionYear;
            Type = type;
            Model = model;
            CubicCentimeters = cubicCm;
            CurrentKM = currentKm;
            Client = client;
            ServiceList = serviceList;
            IsSubscribed = true;

        }

        #endregion

        #region Methods

        public bool IsValidKm(double currentKM)
        {
            Service service = ServiceList[ServiceList.Count - 1];

                if (currentKM < service.ServicedKm || currentKM > 1000000)
                {
                    return false;
                }
            return true;
        }

        public bool HasService()
        {
            if (ServiceList.Count == 0)
                return false;
            else return true ;
        }
        
        public void UpdateVehicleKm()
        {
            CurrentKM = ServiceList[ServiceList.Count - 1].ServicedKm;
        }

        #endregion

    }
}

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
        #region Properties
        private Company company;
        private Client client;
        public string LicensePlate { get; set; }
        public int ProductionYear { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int CubicCentimeters { get; set; }
        public double CurrentKm { get; set; }
        public Company Company
        {
            get { return company; }
            set
            {
                if (client == null) company = value;
            }
        }
        public Client Client { get; set; }
        public List<Service> ServiceList { get; set; }
        public bool IsSubscribed { get; set; }

        #endregion

        #region Conctructors

        public Vehicle()
        {

        }
        public Vehicle(string licensePlate,int productionYear,string type,string model,int cubicCm,double currentKm,Company company,List<Service> serviceList,bool isSubscribed)
        {
            LicensePlate = licensePlate;
            ProductionYear = productionYear;
            Type = type;
            Model = model;
            CubicCentimeters = cubicCm;
            CurrentKm = currentKm;
            Company = company;
            ServiceList = serviceList;
            IsSubscribed = isSubscribed;

        }

        public Vehicle(string licensePlate, int productionYear, string type, string model, int cubicCm, double currentKm, Client client, List<Service> serviceList, bool isSubscribed)
        {
            LicensePlate = licensePlate;
            ProductionYear = productionYear;
            Type = type;
            Model = model;
            CubicCentimeters = cubicCm;
            CurrentKm = currentKm;
            Client = client;
            ServiceList = serviceList;
            IsSubscribed = isSubscribed;

        }

        #endregion

        #region Methods



        #endregion

    }
}

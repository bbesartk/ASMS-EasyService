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

        public string LicensePlate { get; set; }
        public int VIN { get; set; }
        public int ProductionYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int MotorPower { get; set; }
        public double CurrentKm { get; set; }
        public Company Company { get; set; }
        public PrivateClient Client { get; set; }
        public List<Service> ServiceList { get; set; }
        public bool IsSubscribed { get; set; }

        #endregion

        #region Conctructors

        public Vehicle()
        {

        }
        public Vehicle(string licensePlate,int vin,int productionYear,string make,string model,int motorPower,double currentKm,Company company,PrivateClient client,List<Service> serviceList,bool isSubscribed)
        {
            LicensePlate = licensePlate;
            VIN = vin;
            ProductionYear = productionYear;
            Make = make;
            Model = model;
            MotorPower = motorPower;
            CurrentKm = currentKm;
            Company = company;
            Client = client;
            ServiceList = serviceList;
            IsSubscribed = isSubscribed;

        }

        #endregion

        #region Metoda



        #endregion

    }
}

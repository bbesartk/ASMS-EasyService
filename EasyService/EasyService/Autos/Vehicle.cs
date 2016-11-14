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
        private double _correntKm;
        private Company company;
        private Client client;
        #endregion

        #region Properties
        public string LicensePlate { get { return _licensePlate; }
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
                if (value >= 2000)
                {
                    _productionYear = value;
                }
                else
                {
                    throw new Exception("Regjistrohen vetem veturat qe jan mbi 2000");
                }
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                if (value != String.Empty)
                {
                    _type = value;
                }
                else
                {
                    throw new Exception("Ju Lutem shkruaj Tipin ");
                }
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (value != String.Empty)
                {
                    _model = value;
                }
                else
                {
                    throw new Exception("Ju Lutem shkruaj Modelin");
                }
            }
        }
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
        public List<Service> ServiceList { get; set; }//history of secices
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

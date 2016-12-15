using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Clients;
using ES.EntityLayer.Services;

namespace ES.EntityLayer.Vehicle
{
    public class Vehicle
    {
        #region DeclaredAndInitialized
        public List<Service> ServiceList { get; set; } = new List<Service>();
        #endregion

        #region PrivateMembers
        private string _licensePlate;
        private string _vin;
        private int _productionYear;
        private string _type;
        private string _model;
        private int _cubicC;
        private Company _company;
        private Client _client;
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { return _licensePlate; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a license plate!");
                else _licensePlate = value;

            }
        }

        public string Vin
        {
            get { return _vin; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a Vehicle Identification Number!");
                else _vin = value;
            }
        }

        public int ProductionYear
        {
            get { return _productionYear; }

            set
            {
                if (value > 1950 || value <= DateTime.Now.Year)
                    _productionYear = value;
                else throw new Exception("You've entered a non valid production year!");
            }
        }

        public string Type
        {
            get { return _type; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a vehicle type!");
                else _type = value;
            }


        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a vehicle model!");
                else _model = value;
            }
        }

        public int CubicC
        {
            get { return _cubicC; }
            set
            {
                if (value >= 600 && value < 30000) _cubicC = value;
                else throw new Exception("You must provide a valid Cubic Centimeter per Vehicle!");
            }

        }
        public Company Company
        {
            get { return _company; }
            set { if (_client == null) _company = value; }
        }

        public Client Client
        {
            get { return _client; }
            set { if (_company == null) _client = value; }
        }
        public bool IsSubscribed { get; set; }
        #endregion

        #region Constructors
        public Vehicle(string licensePlate, string vin, int productionYear, string type, string model, int cubicCm)
        {
            LicensePlate = licensePlate;
            ProductionYear = productionYear;
            Type = type;
            Model = model;
            Vin = vin;
            CubicC = cubicCm;
            IsSubscribed = true;
        }


        #endregion

        #region Methods

        #endregion
    }
}

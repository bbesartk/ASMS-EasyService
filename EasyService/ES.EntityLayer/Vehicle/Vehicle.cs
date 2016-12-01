using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ES.EntityLayer.Vehicle
{
   public class Vehicle
    {

        #region PrivateMembers
        private string _licensePlate;
        private string _vin;
        private int _productionYear;
        private string _type;
        private string _model;
        private int _cubicC;
        #endregion

        #region Properties
        //public string LicensePlate
        //{
        //    get { return _licensePlate; }

        //    set
        //    {
        //        if (String.IsNullOrEmpty(value))
        //            throw new Exception("You must provide a license plate!");
        //        else if (IsUniquePlate(value))
        //            _licensePlate = value;
        //        else throw new Exception("This plate is not unique!");
        //    }
        //}

        //public string Vin
        //{
        //    get { return _vin; }

        //    set
        //    {
        //        if (String.IsNullOrEmpty(value))
        //            throw new Exception("You must provide a Vehicle Identification Number!");
        //        else if (IsUniqueVIN(value))
        //            _vin = value;
        //        else throw new Exception("This VIN isn't unique!");
        //    }
        //}

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
                _model = value;
            }
        }

        public int CubicC
        {
            get { return _cubicC; }
            set
            {
                if (value >= 600 && value < 30000)
                    _cubicC = value;
                else throw new Exception("You must provide a valid Cubic Centimeter per Vehicle!");
            }

        }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        //private bool IsUniquePlate(string licensePlate)
        //{
        //    List<Vehicle> allVehicle = dalVehicle.GetAll();

        //    foreach (Vehicle vh in allVehicle)
        //    {
        //        if (licensePlate == vh.LicensePlate)
        //            return false;
        //    }
        //    return true;
        //}

        //private bool IsUniqueVIN(string vin)
        //{
        //    List<Vehicle> allVehicle = dalVehicles.GetAll();

        //    foreach (Vehicle vh in allVehicle)
        //    {
        //        if (vin == vh.Vin)
        //            return false;
        //    }
        //    return true;
        //}
        #endregion
    }
}

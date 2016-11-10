using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Clients;
using EasyService.Companys;
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
        public Client Client { get; set; }

        #endregion
    }
}

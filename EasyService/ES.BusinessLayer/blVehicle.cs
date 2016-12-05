using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Vehicle;
using ES.DataAccessLayer;


namespace ES.BusinessLayer
{
    class blVehicle
    {
       static List<Vehicle> AllVehicles = dalVehicle.GetAll();

    }
}

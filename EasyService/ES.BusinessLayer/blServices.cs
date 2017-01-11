using ES.EntityLayer.Services;
using ES.EntityLayer.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DataAccessLayer;
using ES.EntityLayer.Stock;
namespace ES.BusinessLayer
{
    public class blServices
    {

        public static Service GetLastService(Vehicle vh)
        {
            if (vh.ServiceList.Count>0)
                return vh.ServiceList[vh.ServiceList.Count - 1];
            else return null;
        }



        #region Service Types

        public static void InsertNewServiceType(ServiceName serviceName)
        {
            dalServiceName.Insert(serviceName);
        }


        public static void AllServices()
        {
            dalServiceName.Insert(new ServiceName("Instrument gauges, warning/control lights and horn", true, true,true, Category.ServiceParts));
            dalServiceName.Insert(new ServiceName("All exterior lights", true, true, true, Category.ServiceParts));
            dalServiceName.Insert(new ServiceName("Washers-wipers, check all", true, true, true, Category.Transmission));
            dalServiceName.Insert(new ServiceName("Service internal indicator", true, true, true, Category.ServiceParts));
            dalServiceName.Insert(new ServiceName("Engine oil and filter", true, true, true, Category.EngineParts));
            dalServiceName.Insert(new ServiceName("Check all engine fluids", true, true));
            dalServiceName.Insert(new ServiceName("Basic visual check on engine pipes", true, true));
            dalServiceName.Insert(new ServiceName("Washer jet fluid", true, true, true, Category.Lubrificants));
            dalServiceName.Insert(new ServiceName("Check wear and condition especially at tyre wall", true, true,true, Category.Brakes));
            dalServiceName.Insert(new ServiceName("Adjust tyre pressure", true, true));
            dalServiceName.Insert(new ServiceName("Brake System with wheels on", true, true));
            dalServiceName.Insert(new ServiceName("All doors latches - check", true, true));
            dalServiceName.Insert(new ServiceName("Check brake pads and discs for wear", false, true, true, Category.Brakes));
            dalServiceName.Insert(new ServiceName("Steering, Susspension linkages", false, true, true, Category.Brakes));
            dalServiceName.Insert(new ServiceName("Gearbox oil - check level and top up", false, true, true, Category.Lubrificants));
        }
        #endregion


    }
}

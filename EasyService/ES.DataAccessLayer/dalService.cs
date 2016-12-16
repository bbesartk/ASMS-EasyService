using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Services;

namespace ES.DataAccessLayer
{
    class dalService
    {
        private static List<ServiceName> listOfAllServices = new List<ServiceName>();

        public static List<ServiceName> GetAll()
        {
            return listOfAllServices;
        }

        public static void Insert(ServiceName serviceName)
        {
            listOfAllServices.Add(serviceName);
        }
    
        public static void Remove(ServiceName serviceName)
        {
            listOfAllServices.Remove(serviceName);
        }

        
    }
}

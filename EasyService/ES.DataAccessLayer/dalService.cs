using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Services;

namespace ES.DataAccessLayer
{
    public class dalService
    {
        private static List<ServiceName> listOfAllServiceNames = new List<ServiceName>();

        public static List<ServiceName> GetAll()
        {
            return listOfAllServiceNames;
        }

        public static void Insert(ServiceName serviceName)
        {
            listOfAllServiceNames.Add(serviceName);
        }
    
        public static void Remove(ServiceName serviceName)
        {
            listOfAllServiceNames.Remove(serviceName);
        }

        public static ServiceName GetServiceName(string serviceName)
        {
            foreach (var item in listOfAllServiceNames)
            {
                if(serviceName==item.Description)
                {
                    return item;
                }

            }
            return null;
        }

        
    }
}

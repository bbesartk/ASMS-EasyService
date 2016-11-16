using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Vehicles;

namespace ASMS_EasyService.DataAccess_Layer
{
    class dalInspections
    {
        private static List<Inspection> ListOfAllInspections = new List<Inspection>();

        public static List<Inspection> GetAll()
        {
            return ListOfAllInspections;
        }

        public static void Insert(string name)
        {
            ListOfAllInspections.Add(new Inspection(name));
        }

        public static void Delete(string name)
        {
            foreach (Inspection inspection in GetAll())
            {
                if(inspection.Name==name)
                {
                    ListOfAllInspections.Remove(inspection);
                }
            }
        }
    }
}

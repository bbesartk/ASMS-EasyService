using ES.EntityLayer.Finance;
using ES.EntityLayer.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

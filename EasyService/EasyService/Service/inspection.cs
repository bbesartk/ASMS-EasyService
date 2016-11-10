using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Service
{
    class Inspection
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Prise { get; set; }
        #endregion

        #region Conctrucion

        public Inspection()
        {

        }
        public Inspection(int id,string name,string description,double prise)
        {

        }

        #endregion




    }
}

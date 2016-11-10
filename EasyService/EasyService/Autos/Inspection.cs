using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Autos
{
    class Inspection
    {

        #region StaticMembers

        private static int _id=0;

        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Prise { get; set; }
        #endregion

        #region Conctrucion

        public Inspection()
        {
            Id = ++_id;
        }
        public Inspection(int id,string name,string description,double prise)
        {
            Id = ++_id;
            Name = name;
            Description = description;
            Prise = prise;

        }
        #endregion




    }
}

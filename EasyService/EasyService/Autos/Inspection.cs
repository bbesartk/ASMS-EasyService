using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyService.Autos
{
    class Inspection
    {
        #region PrivateMembers
        private string _name;

        #endregion

        #region Properties

        public InspectionServiced Service { get; set; }

        public string Name
        {
            get{ return _name;}
            set
            {
                if (value != String.Empty)
                {
                    _name = value;
                }
                else throw new Exception("Emri s'duhet te jete i zbrazet!");
            }
        }

        #endregion

        #region Conctructors

        public Inspection(string name,InspectionServiced service)
        { 
            Name = name;
            this.Service = service;
        }

        public Inspection(string name)
        {
            Name = name;
            Service = null;
        }


        #endregion

    }
}

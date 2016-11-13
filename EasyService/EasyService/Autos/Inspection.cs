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
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IncspectionServiced Service { get; set; }
        #endregion

        #region Conctructors

        public Inspection()
        {
            Id = ++_id;
        }
        public Inspection(int maxId,string name,string description,IncspectionServiced service)
        {
            Id = maxId + 1;
            Name = name;
            Description = description;
            this.Service = service;
        }

        public Inspection(int maxId, string name, string description)
        {
            Id = maxId + 1;
            Name = name;
            Description = description;
            Service = null;
        }


        #endregion

    }
}

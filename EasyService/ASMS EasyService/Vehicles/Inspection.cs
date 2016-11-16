using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS_EasyService.Vehicles
{
    class Inspection
    {
        #region StaticMembers

        #endregion

        #region PrivateMembers
        private string _name;
        #endregion

        #region Properties
        public ServicedInspection ServicedInspection { get; set; } //if particular inspection is also serviced; this class should be not null

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a name for inspection!");
                else _name = value;
            }
        }
        #endregion

        #region Constructors
        //if there is no serviced inspection, this constructor should be called
        public Inspection(string name)
        {
            Name = name;
            ServicedInspection = null;
        }


        public Inspection(string name, ServicedInspection servicedInspection)
        {
            Name = name;
            ServicedInspection = servicedInspection;
        }
        #endregion

        #region Methods

        #endregion
    }
}

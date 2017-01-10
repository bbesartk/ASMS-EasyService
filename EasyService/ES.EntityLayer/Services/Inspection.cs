using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ES.EntityLayer.Services
{
    public class Inspection
    {
        #region PrivateMembers
        private string _name;
        #endregion

        #region Properties
        public InspectionDetail InspectionDetail { get; set; } //if particular inspection is also serviced; this class should be not null

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("You must provide a name for this inspection!");
                else _name = value;
            }
        }
        #endregion

        #region Constructors
        //if there is no serviced inspection, this constructor should be called
        public Inspection(string name)
        {
            Name = name;
            InspectionDetail = null;
        }


        public Inspection(string name, InspectionDetail servicedInspection)
        {
            Name = name;
            InspectionDetail = servicedInspection;
        }

        public override string ToString()
        {
            return $"{InspectionDetail.Item.Name} | {InspectionDetail.Item.Price} x {InspectionDetail.Quantity}";
        }
        #endregion

        #region Methods

        #endregion
    }
}

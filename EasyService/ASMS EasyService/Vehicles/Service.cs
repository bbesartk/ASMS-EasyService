using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Employees;

namespace ASMS_EasyService.Vehicles
{
    class Service
    {
        #region PrivateMembers
        private double _servicedKm;
        private List<Inspection> _listInspection;
        private decimal _technicalWork;
        #endregion

        #region Properties

        public List<Inspection> ListInspection
        {
            get { return _listInspection; }
            set
            {
                if (value != null)
                    _listInspection = value;
                else throw new ArgumentNullException("Every service must have a list of inspections or serviced inspection service");
            }
        }

        public Employee ServicedBy { get; }

        public DateTime DateOfService { get; set; }

        public decimal Total
        {
            get
            {
                 if(HasServicedInspections())
                    return (TechnicalWorkPay+CalculateTotal());
                else return TechnicalWorkPay;
            }

        }

        public decimal TechnicalWorkPay
        {
            get{return _technicalWork;}

            set
            {
                if (value < 10)
                    throw new Exception("You must provide a value more or equal to 10");
                else _technicalWork = value;
            }
        }

        public double ServicedKm
        {
            get{return _servicedKm;}

            set
            {
                if(value>0)
                _servicedKm = value;
            }
        }

        #endregion

        #region Constructors
        public Service(DateTime dateOfService, double servicedKm,decimal technicalWork, List<Inspection> listOfInspection,Employee servicedBy)
        {
            DateOfService = dateOfService;
            ServicedKm = servicedKm;
            TechnicalWorkPay = technicalWork;
            ListInspection = listOfInspection;
            ServicedBy = servicedBy;
        }
        #endregion

        #region Methods
        //Calculate total for all serviced Inspections
        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Inspection item in ListInspection)
            {
                if (item.ServicedInspection != null)
                {
                    total += item.ServicedInspection.Total;
                }
            }
            return total;
        }
        //Check all Inspections in listOfInspection
        private bool HasServicedInspections()
        {
            foreach (Inspection item in ListInspection)
            {
                if (item.ServicedInspection != null)
                    return true;
            }
            return false;
        }
        #endregion
    }
}

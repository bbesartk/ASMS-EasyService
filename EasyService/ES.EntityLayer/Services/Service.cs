using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Employees;

namespace ES.EntityLayer.Services
{
    public class Service:IEnumerable<Inspection>
    {
        #region PrivateMembers
        private DateTime _dateOfService;
        private double _servicedKm;
        private List<Inspection> _listInspection;
        private double _technicalWork;
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
        public DateTime DateOfService
        {
            get { return _dateOfService; }

            set
            {
                if (value != null)
                    _dateOfService = value;
                else throw new Exception("You must provide a valid date!");
            }
        }

        public double Total
        {
            get;set;

        }

        public double TechnicalWorkPay
        {
            get { return _technicalWork; }

            set
            {
                if (value < 10)
                    throw new Exception("You must provide a value more or equal to 10");
                else _technicalWork = value;
            }
        }

        public double ServicedKm
        {
            get { return _servicedKm; }

            set
            {
                if (value > 0)
                    _servicedKm = value;
            }
        }

        public Employee ServicedBy { get; }

        #endregion

        #region Constructors
        public Service(DateTime dateOfService, double servicedKm, double technicalWork, List<Inspection> listOfInspection, Employee servicedBy, double total)
        {
            DateOfService = dateOfService;
            ServicedKm = servicedKm;
            TechnicalWorkPay = technicalWork;
            ListInspection = listOfInspection;
            ServicedBy = servicedBy;
            Total = total;
        }

        public IEnumerator<Inspection> GetEnumerator()
        {
            return ListInspection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ListInspection.GetEnumerator();
        }
        #endregion

        #region Methods
        //Calculate total for all serviced Inspections

        #endregion
    }
}

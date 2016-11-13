using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Autos;
using EasyService.Employee;
using EasyService.Appointments;

namespace EasyService.Finance
{
    class Bill
    {
        public const double VAT = 0.15;

        #region Properties
        public Vehicle Vehicle { get; set; }
        public List<Inspection> ListOfServicedThings { get; set; }
        DateTime DateOfBill
        {
            get
            {
                return DateTime.Now;
            }
        }
        public Employee.Employee ServicedBy { get; set; }
        public Employee.Employee IssuedBy { get; private set; }
        #endregion

        #region Constructors

        public Bill()
        {

        }

        public Bill(Vehicle vehicle, List<Inspection> listOfServicedThings, Employee.Employee servicedBy, Employee.Employee issuedBy)
        {
            Vehicle = vehicle;
            ListOfServicedThings = listOfServicedThings;
            ServicedBy = servicedBy;
            IssuedBy = issuedBy;
        }
        #endregion


    }
}
